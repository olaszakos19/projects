package labz.crs;

import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class FavoriteService {
    FavoriteRepository favoriteRepository;
    UserRepository userRepository;
    CarRepository carRepository;

    @Autowired
    public FavoriteService(FavoriteRepository favoriteRepository, UserRepository userRepository,
            CarRepository carRepository) {
        this.favoriteRepository = favoriteRepository;
        this.userRepository = userRepository;
        this.carRepository = carRepository;
    }

    public List<Favorite> getFavoritesByUserId(int userId) {
        return favoriteRepository.findByUserId(userId);
    }

    
      public void removeFavorite(int kedvencID){
      favoriteRepository.deleteFavorite(kedvencID);
     }
     

    public void addFavorite(int userId, int carId) {
        Favorite favorite = new Favorite();
        favorite.setUserID(userId);
        favorite.setAutoID(carId);
        if(checkDuplicate(userId, carId) == false){
            favoriteRepository.save(favorite);
        }
   
    }


    void deleteF(int id){
        favoriteRepository.deleteById(id);
    }

    void deleteFavoriteByUserID(int id){
        favoriteRepository.deleteFavoriteByUserID(id);
    }

    void deleteFavoriteByCarID(int id){
        favoriteRepository.deleteFavoriteByCarID(id);
    }



     public Boolean checkDuplicate(int userId,int autoID){
        String isDuplicate = favoriteRepository.isDuplicate(userId,autoID);
        if(isDuplicate != null) return true;
        else return false;
   }
 




}
