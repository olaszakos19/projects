package labz.crs;

import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.Collections;
import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import jakarta.transaction.Transactional;

@Service
public class UserService {
    private final UserRepository userRepository;
    private final List<User> userList;


    @Autowired
    public UserService(UserRepository userRepository,List<User> userList) {
        this.userRepository = userRepository;
        this.userList = userList;
    }

    public User loginUser(String email, String password) {
        return userRepository.findByEmailAndPassword(email, password);
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
            throw new RuntimeException("Hiba", e);
        }
    }


    public void registerUser(User user) {
        String original = user.getpassword();
        String encrypted = enigma(original);
        user.setpassword(encrypted);    
        userRepository.save(user);
    }
    

    public boolean isValidUser(String email, String password) {
        User user = userRepository.findByEmail(email);
        return user != null && user.getpassword().equals(password);
    }

    public boolean isAdmin(String email) {
        Boolean isAdmin = userRepository.findAdminStatusByEmail(email);
        return isAdmin != null && isAdmin;
    }

    public List<User> getAllUser() {
        return userRepository.findAll();
    }

    
    public void promote(int userId,boolean newValue){
        userRepository.promote(userId, newValue);
    }

    
    public List<User> getAllUser(boolean n) {
        return (List<User>) userRepository.getUsers(n);
    } 

    public void deleteU(int userId) {
        userRepository.deleteById(userId);
    }

    public User getUserById(int userId) {
        return userRepository.FindById(userId);
    }
    

    public int getId(String email){
        return userRepository.id(email);
    }

    public Boolean checkDuplicate(String email){
         String isDuplicate = userRepository.isDuplicate(email);
         if(isDuplicate != null) return true;
         else return false;
    }

    @Transactional
    public void updateUserName(int userId, String newVezeteknev,String newKeresztnev) {
        userRepository.updateUserName(userId, newVezeteknev,newKeresztnev);
    }

    @Transactional
    public void updatePhone(int userId, String newPhone) {
        userRepository.updatePhone(userId, newPhone);
    }

    @Transactional
    public void updatePasswd(int userId, String newPasswd) {
        userRepository.updatePasswd(userId, newPasswd);
    }


    @Transactional
    public void addFavorite(int userID,int carId){
        userRepository.addFavorite(carId, userID);
    } 

}
