    package labz.crs;

    import jakarta.persistence.Entity;
    import jakarta.persistence.GeneratedValue;
    import jakarta.persistence.GenerationType;
    import jakarta.persistence.Id;
    import jakarta.persistence.JoinColumn;
    import jakarta.persistence.ManyToOne;
    import jakarta.persistence.Table;

    @Entity
    @Table(name="foglalasok")
    public class Reservation {
        @Id
        @GeneratedValue(strategy = GenerationType.IDENTITY)
        private int FoglalasID;
        private int UserID;
        private int AutoID;
        private String kezdet;
        private String veg;
        private int Osszeg;
        private int allapot;

        @ManyToOne
        @JoinColumn(name = "AutoID",insertable=false, updatable=false)
        private Car car;

        @ManyToOne
        @JoinColumn(name = "UserID",insertable=false, updatable=false)
        private User user;


        public int getFoglalasID() {
            return FoglalasID;
        }

        public void setFoglalasID(int foglalasID) {
            FoglalasID = foglalasID;
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

        public String getKezdet() {
            return kezdet;
        }

        public void setKezdet(String kezdet) {
            this.kezdet = kezdet;
        }

        public String getVeg() {
            return veg;
        }

        public void setVeg(String veg) {
            this.veg = veg;
        }

        public int getOsszeg() {
            return Osszeg;
        }

        public void setOsszeg(int osszeg) {
            Osszeg = osszeg;
        }

        public int getAllapot() {
            return allapot;
        }
        

        public void setAllapot(int a){
            this.allapot = a;
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
            return "Reservation{" +
                    "FoglalasID=" + FoglalasID +
                    ", UserID=" + UserID +
                    ", AutoID=" + AutoID +
                    ", kezdet='" + kezdet + '\'' +
                    ", veg='" + veg + '\'' +
                    ", Osszeg=" + Osszeg +
                    '}';
        }
    }
