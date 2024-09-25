package labz.crs;

import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

public interface CarRepository extends JpaRepository<Car, Integer> {

    @Query("SELECT COUNT(a) FROM Car a WHERE a.is_reserved = 0")
    long countByAvailable();

    @Query("SELECT COUNT(a) FROM Car a WHERE a.is_reserved = 1")
    long countByReserved();

    @Query("SELECT COUNT(a) FROM Car a WHERE a.is_damaged = 1")
    long countByDamaged();

    @Query("SELECT c FROM Car c WHERE c.AutoID = :AutoID")
    Car FindById(@Param("AutoID") int AutoID);

    @Query("SELECT c FROM Car c WHERE c.kivitel = :type")
    Page<Car> findByKivitel(@Param("type") int type, Pageable pageable);

    @Query("SELECT c FROM Car c WHERE c.fuel_type = :type")
    Page<Car> findByFuel(@Param("type") int type, Pageable pageable);

    @Query("SELECT c FROM Car c WHERE c.ValtoTipus = :type")
    Page<Car> findByTransmission(@Param("type") int type, Pageable pageable);

    @Query("SELECT c FROM Car c WHERE c.is_reserved = :reserved AND c.is_damaged = :damaged")
    Page<Car> findCars(Pageable pageable, @Param("reserved") int reserved, @Param("damaged") int damaged);

    @Query("SELECT c.rendszam FROM Car c WHERE c.rendszam =: rendszam")
    String isDuplicate(@Param("rendszam") String rendszam);
    
    @Modifying
    @Query("UPDATE Car c SET c.is_damaged = :damaged WHERE c.AutoID = :AutoID")
    void damagedCar(@Param("AutoID") int AutoID, @Param("damaged") int damaged);

    @Modifying
    @Query("UPDATE Car c SET c.is_reserved = :reserved WHERE c.AutoID = :AutoID")
    void reservedCar(@Param("AutoID") int AutoID, @Param("reserved") int reserved);

    @Modifying
    @Query("UPDATE Car c SET c.cost = :newCost WHERE c.AutoID = :AutoID")
    void updateCost(@Param("AutoID") int AutoID, @Param("newCost") int newCost);

    @Modifying
    @Query("UPDATE Car c SET c.loero = :newLe WHERE c.AutoID = :AutoID")
    void updateLe(@Param("AutoID") int AutoID, @Param("newLe") int newLe);

    Page<Car> findAll(Pageable pageable);

}
