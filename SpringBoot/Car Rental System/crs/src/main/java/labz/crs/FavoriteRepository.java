package labz.crs;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

public interface FavoriteRepository extends JpaRepository<Favorite, Integer>{
    
    @Query("SELECT f FROM Favorite f JOIN FETCH f.car c JOIN f.user u WHERE u.UserID = :userId")
    List<Favorite> findByUserId(@Param("userId") int userId);

    @Query("SELECT f.KedvencID FROM Favorite f JOIN f.car c JOIN f.user u WHERE u.UserID = :userId AND c.AutoID = :carId")
    String isDuplicate(@Param("userId") int userId, @Param("carId") int carId);
    

    @Modifying
    @Query("DELETE FROM Favorite f WHERE f.KedvencID = :kedvencID")
    void deleteFavorite(@Param("kedvencID") int kedvencID); 

    
    @Modifying
    @Query("DELETE FROM Favorite f WHERE f.UserID = :userId")
    void deleteFavoriteByUserID(@Param("userId") int userId); 

    @Modifying
    @Query("DELETE FROM Favorite f WHERE f.AutoID = :carId")
    void deleteFavoriteByCarID(@Param("carId") int carId); 




}
