using Models;

namespace Data
{
    public class VehicleHandler
    {
        public string AddVehicle(Vehicle vehicle)
        {
            if (vehicle == null)
            {
                throw new ArgumentNullException(nameof(vehicle));
            }

            using var context = new DataContext();
            context.Vehicles.Add(vehicle);
            context.SaveChanges();
            return "Vehicle added succesfully";
        }

        public string RemoveVehicle(Vehicle vehicle)
        {
            if (vehicle == null)
            {
                throw new ArgumentNullException(nameof(vehicle));
            }

            using var context = new DataContext();
            context.Vehicles.Remove(vehicle);
            context.SaveChanges();
            return "Vehicle removed succesfully";
        }

        public string UpdateVEhicle(Vehicle vehicle) 
        {
            if (vehicle == null)
            {
                throw new ArgumentNullException(nameof(vehicle));
            }

           

            using var context = new DataContext();

            var cuv = context.Vehicles.FirstOrDefault(v =>v.LicensePlate == vehicle.LicensePlate);

            cuv.LicensePlate = vehicle.LicensePlate;
            cuv.Brand = vehicle.Brand;
            cuv.Type = vehicle.Type;
            cuv.Color = vehicle.Color;

            context.SaveChanges();
            return "Vehicle updated succesfully";
        }

        public  Vehicle GetVehicleByLicenseplate(string licenseplate)
        {
            if (licenseplate == null)
            {
                throw new ArgumentException(nameof(licenseplate));
            }

            using var context = new DataContext();
            return context.Vehicles.FirstOrDefault(v => v.LicensePlate == licenseplate);
        }

        public  List<Vehicle> GetVehiclesByUserId(int userId)
        {
            if (userId == null)
            {
                throw new ArgumentException(nameof(userId));
            }

            using var context = new DataContext();

            return context.Vehicles.Where(v => v.UserId == userId).ToList();
        }

        public List<Vehicle> GetAllVehicle() 
        { 
            using var context = new DataContext();
            return context.Vehicles.ToList();
        }

        /*
        public bool isParking(Vehicle vehicle) 
        {
            if (vehicle == null)
            {
                throw new ArgumentNullException(nameof(vehicle));
            }

            using var context = new DataContext();
            
        }
        */

    }
}
