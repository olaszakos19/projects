package labz.crs;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

public interface UserRepository extends JpaRepository<User, Integer> {
    User findByEmailAndPassword(String email, String password);

    @Query("SELECT u FROM User u WHERE u.email = :email")
    User findByEmail(@Param("email") String email);

    @Query("SELECT u.email FROM User u WHERE u.email = :email")
    String isDuplicate(@Param("email") String email);

    @Query("SELECT u.is_admin FROM User u WHERE u.email = :email")
    Boolean findAdminStatusByEmail(@Param("email") String email);

    @Query("SELECT u FROM User u WHERE u.is_admin = :isadmin")
    List<User> getUsers(@Param("isadmin") boolean isadmin);

    @Query("SELECT u FROM User u WHERE u.UserID = :UserID")
    User FindById(@Param("UserID") int UserID);

    @Modifying
    @Query("INSERT INTO Favorite (UserID, AutoID) VALUES (:UserID, :AutoID)")
    void addFavorite(@Param("UserID") int UserID, @Param("AutoID") int AutoID);

    @Query("SELECT u.UserID FROM User u WHERE u.email = :email")
    Integer id(@Param("email") String email);

    @Modifying
    @Query("UPDATE User u SET u.vezeteknev = :newVezeteknev,u.keresztnev = :newKeresztnev WHERE u.id = :userId")
    void updateUserName(@Param("userId") int userId, @Param("newVezeteknev") String newVezeteknev,@Param("newKeresztnev") String newKeresztnev);

    @Modifying
    @Query("UPDATE User u SET u.password = :newPass WHERE u.id = :userId")
    void updatePasswd(@Param("userId") int userId, @Param("newPass") String newPass);

    @Modifying
    @Query("UPDATE User u SET u.telefonszam = :newPhone WHERE u.id = :userId")
    void updatePhone(@Param("userId") int userId, @Param("newPhone") String newPhone);

    @Modifying
    @Query("UPDATE User u SET u.is_admin = :newValue WHERE u.id = :userId")
    void promote(@Param("userId") int userId, @Param("newValue") boolean newValue);

}
