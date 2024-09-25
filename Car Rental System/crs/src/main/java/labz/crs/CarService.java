package labz.crs;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.PageRequest;
import org.springframework.stereotype.Service;

import jakarta.transaction.Transactional;

import java.util.List;

@Service
public class CarService {

    private final CarRepository carRepository;

    @Autowired
    public CarService(CarRepository carRepository) {
        this.carRepository = carRepository;
    }

    public List<Car> getAllCars() {
        return carRepository.findAll();
    }

    public void register_car(Car car) {
        carRepository.save(car);
    }

    public void deleteCar(int carId) {
        carRepository.deleteById(carId);
    }

    public Car getCarById(int AutoID) {
        return carRepository.FindById(AutoID);
    }

    public Boolean checkDuplicate(String rendszam) {
        String isDuplicate = carRepository.isDuplicate(rendszam);
        if (isDuplicate != null)
            return true;
        else
            return false;
    }

    public Page<Car> getAllAvaliableCars(int page, int size, int reserved, int damaged) {
        PageRequest pageRequest = PageRequest.of(page, size);
        return carRepository.findCars(pageRequest, reserved, damaged);
    }

    @Transactional
    public void update_damage(int carId, int damage) {
        carRepository.damagedCar(carId, damage);
    }

    @Transactional
    public void update_reserve(int carId, int reserve) {
        carRepository.reservedCar(carId, reserve);
    }

    @Transactional
    public void update_cost(int carId, int newCost) {
        carRepository.updateCost(carId, newCost);
    }

    @Transactional
    public void update_le(int carId, int newLe) {
        carRepository.updateLe(carId, newLe);
    }

    public Page<Car> getAllCars(int page, int size) {
        PageRequest pageRequest = PageRequest.of(page, size);
        return carRepository.findAll(pageRequest);
    }

    public Page<Car> getByFuel(int page, int size, int type) {
        PageRequest pageRequest = PageRequest.of(page, size);
        return carRepository.findByFuel(type, pageRequest);
    }

    public Page<Car> getByKivitel(int page, int size, int type) {
        PageRequest pageRequest = PageRequest.of(page, size);
        return carRepository.findByKivitel(type, pageRequest);
    }

    public Page<Car> getByTransmision(int page, int size, int type) {
        PageRequest pageRequest = PageRequest.of(page, size);
        return carRepository.findByTransmission(type, pageRequest);
    }

    public long getAllCarsCount() {
        return carRepository.count();
    }

    public long getAvailableCarsCount() {
        return carRepository.countByAvailable();
    }

    public long getReservedCarsCount() {
        return carRepository.countByReserved();
    }

    public long getDamagedCarsCount() {
        return carRepository.countByDamaged();
    }

}
