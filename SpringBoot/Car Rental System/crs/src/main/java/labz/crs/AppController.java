package labz.crs;

import java.io.File;
import java.io.IOException;
import java.nio.file.FileVisitOption;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.EnumSet;
import java.util.List;

import org.apache.tomcat.util.http.fileupload.FileUtils;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.multipart.MultipartFile;
import org.springframework.web.servlet.ModelAndView;
import org.springframework.web.servlet.view.RedirectView;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpSession;
import jakarta.transaction.Transactional;

@Controller
public class AppController {

    private final UserService userService;
    private final CarService carService;
    private final FavoriteService favoriteService;
    private final ReservationService reservationService;

    @Autowired
    public AppController(UserService userService, CarService carService, FavoriteService favoriteService,
            ReservationService reservationService) {
        this.userService = userService;
        this.carService = carService;
        this.favoriteService = favoriteService;
        this.reservationService = reservationService;
    }

    private String enigma(String password) {
        try {
            MessageDigest md = MessageDigest.getInstance("MD5");
            byte[] messageDigest = md.digest(password.getBytes());

            StringBuilder hexString = new StringBuilder();
            for (byte b : messageDigest) {
                hexString.append(String.format("%02x", b));
            }

            return hexString.toString();
        } catch (NoSuchAlgorithmException e) {
            throw new RuntimeException("MD5 algorithm not available", e);
        }
    }

    // --main felületek
    @GetMapping("/usermain")
    public String getCars(@RequestParam(defaultValue = "0") int page,
            @RequestParam(defaultValue = "6") int size,
            Model model, HttpSession session) {
        if (!isUserLoggedIn(session)) {
            return "redirect:/login";
        }

        int userId = (int) session.getAttribute("userId");
        Page<Car> pagedCars = carService.getAllAvaliableCars(page, size, 0, 0);
        model.addAttribute("pagedCars", pagedCars);
        model.addAttribute("userID", userId);

        return "usermain";
    }

    @GetMapping("/admin")
    public String adminPage(@RequestParam(defaultValue = "0") int page,
            @RequestParam(defaultValue = "6") int size,
            Model model, HttpSession session) {
        Boolean isAdmin = (Boolean) session.getAttribute("isAdmin");
        if (isAdmin == null || !isAdmin) {
            return "redirect:/login";
        } else {
            Page<Car> pagedCars = carService.getAllCars(page, size);
            model.addAttribute("pagedCars", pagedCars);
            model.addAttribute("allCarsCount", carService.getAllCarsCount());
            model.addAttribute("availableCarsCount", carService.getAvailableCarsCount());
            model.addAttribute("reservedCarsCount", carService.getReservedCarsCount());
            model.addAttribute("damagedCarsCount", carService.getDamagedCarsCount());

            return "admin";
        }

    }

    // ----
    // --- login/reg-----
    @PostMapping("/login")
    public String processLogin(@RequestParam String email, @RequestParam String password, HttpServletRequest request,
            HttpSession session) {
        String encrypted = enigma(password);

        if (userService.isValidUser(email, encrypted)) {
            int userId = userService.getId(email);
            boolean isAdmin = userService.isAdmin(email);
            session.setAttribute("userId", userId);
            session.setAttribute("isAdmin", isAdmin);

            if (isAdmin) {
                return "redirect:/admin";
            } else {
                return "redirect:/usermain";
            }
        } else {
            return "redirect:/login?error";
        }
    }

    private boolean isUserLoggedIn(HttpSession session) {
        return session.getAttribute("userId") != null;
    }

    @GetMapping("/login")
    public String getLoginPage(HttpSession session) {

        return "index";
    }

    @GetMapping("/logout")
    public String logout(HttpSession session) {

        session.invalidate();
        return "redirect:/login";
    }

    @GetMapping("/registration")
    public String showRegistrationForm(Model model) {
        model.addAttribute("user", new User());
        return "registration";
    }

    @PostMapping("/register")
    public String registerUser(@ModelAttribute("user") User user) {
        if (userService.checkDuplicate(user.getEmail()) == true) {
            return "redirect:/login";
        } else {
            userService.registerUser(user);
            return "redirect:/login";
        }

    }
    // ------

    // ---- create new

    @PostMapping("/register_car")
    public String registerCar(@ModelAttribute("car") Car car, @RequestParam("img1") MultipartFile img1,
            @RequestParam("img2") MultipartFile img2, @RequestParam("img3") MultipartFile img3) {

        carService.register_car(car);
        var directoryPath = "C:\\Users\\user\\Desktop\\CRS\\crs\\src\\main\\resources\\static\\images\\autok\\"
                + car.getRendszam();

        var file = new java.io.File(directoryPath);
        var path = file.mkdir();

        try {
            img1.transferTo(new java.io.File(directoryPath + "\\1.png"));
            img2.transferTo(new java.io.File(directoryPath + "\\2.png"));
            img3.transferTo(new java.io.File(directoryPath + "\\3.png"));
        } catch (IOException e) {
            e.printStackTrace();
        }

        return "redirect:/admin";
    }

    @Transactional
    @PostMapping("/register_admin")
    public String registerAdmin(@ModelAttribute("user") User user) {
        userService.registerUser(user);
        userService.promote(user.getId(), true);
        return "redirect:/admin";
    }

    @PostMapping("/register_reservation")
    public String registerReservation(@ModelAttribute("reservation") Reservation reservation) {
        reservationService.reserve_car(reservation);
        carService.update_reserve(reservation.getAutoID(), 1);
        return "redirect:/usermain";
    }

    // -----------------------

    @PostMapping("/details")
    public String getCarDetails(@ModelAttribute("AutoID") int AutoID, Model model, HttpSession session) {
        int id = AutoID;
        Car car = carService.getCarById(id);
        model.addAttribute("car", car);
        String img1 = "/images/autok/" + car.getRendszam() + "/1.png";
        String img2 = "/images/autok/" + car.getRendszam() + "/2.png";
        String img3 = "/images/autok/" + car.getRendszam() + "/3.png";
        model.addAttribute("img1", img1);
        model.addAttribute("img2", img2);
        model.addAttribute("img3", img3);
        Boolean isAdmin = (Boolean) session.getAttribute("isAdmin");
        if (isAdmin == true) {
            return "car_details_admin";
        } else {
            return "car_details";
        }
    }

    // oldal navigálás
    @PostMapping("/go_to")
    public ModelAndView goTo(@ModelAttribute("oldal") String oldal) {
        try {
            String o = oldal;
            return new ModelAndView(new RedirectView("/" + o));
        } catch (Exception e) {
            return new ModelAndView("errorPage", "error", "Hiba történt: " + e.getMessage());
        }
    }

    // -------------
    @PostMapping("/reservation")
    public String reservationPage(@ModelAttribute("AutoID") int carId, Model model, HttpSession session) {
        int cId = carId;
        Car car = carService.getCarById(cId);
        int userId = (int) session.getAttribute("userId");
        User user = userService.getUserById(userId);
        model.addAttribute("car", car);
        model.addAttribute("user", user);
        return "reservation";

    }

    @GetMapping("/my_reservation")
    public String getReservation(Model model, HttpSession session) {
        int userId = (int) session.getAttribute("userId");
        List<Reservation> reservations = reservationService.getUserReservation(userId);
        model.addAttribute("reservations", reservations);
        return "my_reservation";
    }

    @GetMapping("/all_reservations")
    public String getAllReservation(Model model) {
        List<Reservation> reservation = reservationService.getAllReservation();
        model.addAttribute("reservation", reservation);
        return "reservations";
    }

    @PostMapping("/fuel")
    public String getCarsByFuel(@RequestParam(defaultValue = "0") int page,
            @RequestParam(defaultValue = "6") int size,
            Model model, @ModelAttribute("fuel") int type) {
        int t = type;
        Page<Car> pagedCars = carService.getByFuel(page, size, t);
        model.addAttribute("pagedCars", pagedCars);
        return "usermain";
    }

    @PostMapping("/kivitel")
    public String getCarsByKivitel(@RequestParam(defaultValue = "0") int page,
            @RequestParam(defaultValue = "6") int size,
            Model model, @ModelAttribute("kivitel") int type) {
        int t = type;
        Page<Car> pagedCars = carService.getByFuel(page, size, t);
        model.addAttribute("pagedCars", pagedCars);
        return "usermain";
    }

    @GetMapping("/transmision")
    public String getCarsByTransmision(@RequestParam(defaultValue = "0") int page,
            @RequestParam(defaultValue = "6") int size,
            Model model, @ModelAttribute("trs") int type) {
        int t = type;
        Page<Car> pagedCars = carService.getByFuel(page, size, t);
        model.addAttribute("pagedCars", pagedCars);
        return "usermain";
    }

    @GetMapping("/cars")
    public String getAllCars(Model model) {
        List<Car> cars = carService.getAllCars();
        model.addAttribute("cars", cars);
        return "carList";
    }

    @GetMapping("/users")
    public String getUsers(Model model) {
        List<User> users = userService.getAllUser(false);
        model.addAttribute("users", users);
        return "users";
    }

    @GetMapping("/favorites")
    public String getUserFavorites(Model model, HttpSession session) {
        int userId = (int) session.getAttribute("userId");
        List<Favorite> favorites = favoriteService.getFavoritesByUserId(userId);
        model.addAttribute("favorites", favorites);
        return "fav";
    }

    @GetMapping("/user")
    public String changeUser(Model model, HttpSession session) {
        int userId = (int) session.getAttribute("userId");
        User user = userService.getUserById(userId);
        model.addAttribute("user", user);
        return "chg_user";
    }

    @PostMapping("/add")
    public ModelAndView addFavoriteGet(@ModelAttribute("AutoID") int AutoID, HttpSession session) {
        try {

            int userId = (int) session.getAttribute("userId");
            int cId = AutoID;
            favoriteService.addFavorite(userId, cId);   
            return new ModelAndView(new RedirectView("/usermain"));
        } catch (Exception e) {
            return new ModelAndView("errorPage", "error", "Hiba történt: " + e.getMessage());
        }
    }

    @GetMapping("/new_admin")
    public String newAdmin() {
        return "new_admin";
    }

    @GetMapping("/new_car")
    public String newCar() {
        return "new_car";
    }

    // ----- deleting
    @Transactional
    @PostMapping("/deleteUser")
    public ModelAndView deleteUser(@ModelAttribute("userId") int userId) {
        try {
            int uId = userId;
            userService.deleteU(uId);
            favoriteService.deleteFavoriteByUserID(uId);
            return new ModelAndView(new RedirectView("/users"));
        } catch (Exception e) {
            return new ModelAndView("errorPage", "error", "Hiba történt: " + e.getMessage());
        }
    }

    @PostMapping("/deleteFavorite")
    public ModelAndView deleteFavorite(@ModelAttribute("KedvencID") int KedvencID) {
        try {
            int kId = KedvencID;
            favoriteService.deleteF(kId);
            return new ModelAndView(new RedirectView("/favorites"));
        } catch (Exception e) {
            return new ModelAndView("errorPage", "error", "Hiba történt: " + e.getMessage());
        }
    }

    @Transactional
    @PostMapping("/deleteCar")
    public ModelAndView deleteCar(@ModelAttribute("carId") int carId) {
        try {
            int cId = carId;
            Car car = carService.getCarById(cId);
            var directoryPath = "C:\\Users\\user\\Desktop\\CRS\\crs\\src\\main\\resources\\static\\images\\autok\\"
                    + car.getRendszam();
            FileUtils.deleteDirectory(new File(directoryPath));
            carService.deleteCar(cId);
            favoriteService.deleteFavoriteByCarID(cId);
            return new ModelAndView(new RedirectView("/admin"));
        } catch (Exception e) {
            return new ModelAndView("errorPage", "error", "Hiba történt: " + e.getMessage());
        }
    }

    // -------

    // ----------------user update--------------------------
    @PostMapping("/update_name")
    public ModelAndView updateName(@ModelAttribute("newVezeteknev") String newVezeteknev,
            @ModelAttribute("newKeresztnev") String newKeresztnev, HttpSession session) {

        try {
            String nk = newKeresztnev;
            String nv = newVezeteknev;
            int userId = (int) session.getAttribute("userId");
            userService.updateUserName(userId, nv, nk);
            return new ModelAndView(new RedirectView("/user"));
        } catch (Exception e) {
            return new ModelAndView("errorPage", "error", "Hiba történt: " + e.getMessage());
        }
    }

    @PostMapping("/update_phone")
    public ModelAndView updatePhoneNumber(@ModelAttribute("newPhone") String newPhone, HttpSession session) {

        try {
            int userId = (int) session.getAttribute("userId");
            userService.updatePhone(userId, newPhone);
            return new ModelAndView(new RedirectView("/user"));
        } catch (Exception e) {
            return new ModelAndView("errorPage", "error", "Hiba történt: " + e.getMessage());
        }
    }

    @PostMapping("/update_passwd")
    public ModelAndView updatePasswd(@ModelAttribute("newPasswd") String newPasswd, HttpSession session) {
        try {
            String encrypted = enigma(newPasswd);
            int userId = (int) session.getAttribute("userId");
            userService.updatePasswd(userId, encrypted);
            return new ModelAndView(new RedirectView("/user"));
        } catch (Exception e) {
            return new ModelAndView("errorPage", "error", "Hiba történt: " + e.getMessage());
        }
    }
    // ----------------car update--------------------------

    @PostMapping("/update_cost")
    public ModelAndView updateCost(@ModelAttribute("AutoID") int carId, @ModelAttribute("newCost") int newCost) {
        try {
            int cId = carId;
            int nc = newCost;
            carService.update_cost(cId, nc);
            return new ModelAndView("redirect:/admin");
        } catch (Exception e) {
            return new ModelAndView("errorPage", "error", "Hiba történt: " + e.getMessage());
        }
    }

    @PostMapping("/update_le")
    public ModelAndView updateLe(@ModelAttribute("AutoID") int carId, @ModelAttribute("newLe") int newLe) {
        try {
            int cId = carId;
            int nl = newLe;
            carService.update_le(cId, nl);
            return new ModelAndView("redirect:/admin");
        } catch (Exception e) {
            return new ModelAndView("errorPage", "error", "Hiba történt: " + e.getMessage());
        }
    }

    @PostMapping("/update_damage")
    public ModelAndView updateDamage(@ModelAttribute("AutoID") int AutoID, @ModelAttribute("newDamage") int newDamage) {
        try {
            int cId = AutoID;
            int nDmg = newDamage;
            carService.update_damage(cId, nDmg);
            return new ModelAndView(new RedirectView("/admin"));
        } catch (Exception e) {
            return new ModelAndView("errorPage", "error", "Hiba történt: " + e.getMessage());
        }
    }

    @PostMapping("/close")
    public ModelAndView closeReservation(@ModelAttribute("AutoID") int AutoID,
            @ModelAttribute("FoglalasID") int FoglalasID) {
        try {
            int cId = AutoID;
            int rId = FoglalasID;
            carService.update_reserve(cId, 0);
            reservationService.updateAllapot(rId, 1);
            return new ModelAndView(new RedirectView("/all_reservations"));
        } catch (Exception e) {
            return new ModelAndView("errorPage", "error", "Hiba történt: " + e.getMessage());
        }
    }

}
