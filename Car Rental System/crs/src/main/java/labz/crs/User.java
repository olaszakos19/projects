package labz.crs;


import java.util.List;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.OneToMany;
import jakarta.persistence.Table;



@Entity
@Table(name = "users")

public class User {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int UserID;
    private String vezeteknev;
    private String keresztnev;
    private String password;
    private String email;
    private String telefonszam;
    private boolean is_admin;


    @OneToMany(mappedBy = "user")
    private List<Favorite> favorites;

    @OneToMany(mappedBy = "user")
    private List<Reservation> reservations;

    public int getId() {
        return UserID;
    }

    public void setId(int UserID) {
        this.UserID = UserID;
    }

    public String getVezeteknev() {
        return vezeteknev;
    }

    public void setVezeteknev(String vezeteknev) {
        this.vezeteknev = vezeteknev;
    }

    public String getKeresztnev() {
        return keresztnev;
    }

    public void setKeresztnev(String keresztnev) {
        this.keresztnev = keresztnev;
    }

    public String getpassword() {
        return password;
    }

    public void setpassword(String password) {
        this.password = password;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getTelefonszam() {
        return telefonszam;
    }

    public void setTelefonszam(String telefonszam) {
        this.telefonszam = telefonszam;
    }



    @java.lang.Override
    public java.lang.String toString() {
        return "User{" +
                "UserID=" + UserID +
                ", vezeteknev='" + vezeteknev + '\'' +
                ", keresztnev='" + keresztnev + '\'' +
                ", password='" + password + '\'' +
                ", email='" + email + '\'' +
                ", telefonszam='" + telefonszam + '\'' +
                '}';
    }

    public void setRoles(List<String> singletonList) {
    }

    public boolean is_admin() {
        return is_admin;
    }
    
    public void setAdmin(boolean admin) {
        is_admin = admin;
    }


}