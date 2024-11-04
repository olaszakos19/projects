package labz.crs;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import jakarta.transaction.Transactional;

@Service
public class ReservationService {
    ReservationRepository reservationRepository;
    UserRepository userRepository;
    CarRepository carRepository;

    @Autowired
    public ReservationService(ReservationRepository reservationRepository, UserRepository userRepository,
            CarRepository carRepository) {
        this.reservationRepository = reservationRepository;
        this.userRepository = userRepository;
        this.carRepository = carRepository;
    }

    public void reserve_car(Reservation reservation){
        reservationRepository.save(reservation);
    }

    public List<Reservation> getUserReservation(int id){
        return reservationRepository.selectByUserId(id);
   
    }

    public List<Reservation> getAllReservation(){
        return reservationRepository.findAll();
        
    }

    @Transactional
    public void updateAllapot(int foglalasID,int newAllapot){
        reservationRepository.reservedCar(foglalasID, newAllapot);
    }



}
