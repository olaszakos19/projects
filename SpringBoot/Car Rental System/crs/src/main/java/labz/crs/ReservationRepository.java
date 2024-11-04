package labz.crs;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

public interface ReservationRepository extends JpaRepository<Reservation, Integer>{


    @Query("SELECT r FROM Reservation r JOIN FETCH r.car c JOIN FETCH r.user u WHERE u.id = :userId AND r.allapot = 0")
    List<Reservation> selectByUserId(@Param("userId") int userId);
    
    @Query("SELECT r FROM Reservation r JOIN FETCH r.car c JOIN r.user u")
    List<Reservation> selectAll();

    @Modifying
    @Query("UPDATE Reservation r SET r.allapot = :newAllapot WHERE r.FoglalasID = :FoglalasID")
    void reservedCar(@Param("FoglalasID") int FoglalasID, @Param("newAllapot") int newAllapot);
    
    
}
