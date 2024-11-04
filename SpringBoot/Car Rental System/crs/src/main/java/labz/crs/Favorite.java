package labz.crs;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.Table;

@Entity
@Table(name = "kedvencek")
public class Favorite {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int KedvencID;
    private int UserID;
    private int AutoID;

    @ManyToOne
    @JoinColumn(name = "AutoID",insertable=false, updatable=false)
    private Car car;

    @ManyToOne
    @JoinColumn(name = "UserID",insertable=false, updatable=false)
    private User user;

    public int getKedvencID() {
        return KedvencID;
    }

    public void setKedvencID(int kedvencID) {
        KedvencID = kedvencID;
    }

    public int getUserID() {
        return UserID;
    }

    public void setUserID(int userID) {
        UserID = userID;
    }

    public int getAutoID() {
        return AutoID;
    }

    public void setAutoID(int autoID) {
        AutoID = autoID;
    }

    public Car getCar() {
        return car;
    }

    public void setCar(Car car) {
        this.car = car;
    }

    public User getUser() {
        return user;
    }

    public void setUser(User user) {
        this.user = user;
    }

    @java.lang.Override
    public java.lang.String toString() {
        return "Favorite{" +
                "KedvencID=" + KedvencID +
                ", UserID=" + UserID +
                ", AutoID=" + AutoID +
                ", car=" + car +
                ", user=" + user +
                '}';
    }
}
