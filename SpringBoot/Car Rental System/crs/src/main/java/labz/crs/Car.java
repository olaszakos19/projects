package labz.crs;

import java.util.List;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.OneToMany;
import jakarta.persistence.Table;

@Entity
@Table(name = "autok")
public class Car {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int AutoID;
    private String marka;
    private String tipus;
    private int kivitel;
    private String rendszam;
    private int ValtoTipus;
    private int loero;
    private int ulesek_szama;
    private int ajtok_szama;
    private String kepek;
    private int fuel_type;
    private int cost;
    private int is_damaged;
    private int is_reserved;
    private int evjarat;

    @OneToMany(mappedBy = "car")
    private List<Favorite> favorites;

    @OneToMany(mappedBy = "car")
    private List<Reservation> reservations;

    public int getAutoID() {
        return AutoID;
    }

    public void setAutoID(int autoID) {
        AutoID = autoID;
    }

    public String getMarka() {
        return marka;
    }

    public void setMarka(String marka) {
        this.marka = marka;
    }

    public String getTipus() {
        return tipus;
    }

    public void setTipus(String tipus) {
        this.tipus = tipus;
    }

    public int getKivitel() {
        return kivitel;
    }

    public void setKivitel(int kivitel) {
        this.kivitel = kivitel;
    }

    public String getRendszam() {
        return rendszam;
    }

    public void setRendszam(String rendszam) {
        this.rendszam = rendszam;
    }

    public int getValtoTipus() {
        return ValtoTipus;
    }

    public void setValtoTipus(int valtoTipus) {
        ValtoTipus = valtoTipus;
    }

    public int getLoero() {
        return loero;
    }

    public void setLoero(int loero) {
        this.loero = loero;
    }

    public int getUlesek_szama() {
        return ulesek_szama;
    }
    
    public void setUlesek_szama(int ulesek_szama) {
        this.ulesek_szama = ulesek_szama;
    }

    public int getAjtok_szama() {
        return ajtok_szama;
    }
    
    public void setAjtok_szama(int ajtok_szama) {
        this.ajtok_szama = ajtok_szama;
    }

    public String getKepek() {
        return kepek;
    }

    public void setKepek(String kepek) {
        this.kepek = kepek;
    }

    public int getFuel_type() {
        return fuel_type;
    }

    public void setfuel_type(int fuel_type) {
        this.fuel_type = fuel_type;
    }

    public int getCost() {
        return cost;
    }

    public void setCost(int cost) {
        this.cost = cost;
    }

    public int getIs_damaged() {
        return is_damaged;
    }

    public void setIs_damaged(int is_damaged) {
        this.is_damaged = is_damaged;
    }

    public int getis_reserved() {
        return is_reserved;
    }

    public void setis_reserved(int is_reserved) {
        this.is_reserved = is_reserved;
    }

    public void setEvjarat(int evjarat){
        this.evjarat = evjarat;
    }

    public int getEvjarat() {
        return evjarat;
    }


    @java.lang.Override
    public java.lang.String toString() {
        return "Car{" +
                "AutoID=" + AutoID +
                ", marka='" + marka + '\'' +
                ", tipus='" + tipus + '\'' +
                ", kivitel=" + kivitel +
                ", rendszam='" + rendszam + '\'' +
                ", ValtoTipus=" + ValtoTipus +
                ", loero=" + loero +
                ", ulesek_szama=" + ulesek_szama +
                ", ajtok_szama=" + ajtok_szama +
                ", kepek='" + kepek + '\'' +
                ", fuel_type=" + fuel_type +
                ", cost=" + cost +
                ", is_damaged=" + is_damaged +
                ", is_reserved=" + is_reserved +
                '}';
    }

}
