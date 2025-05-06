using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ParkingHandler
    {
        public string AddParkinglot(Parkinglot parkinglot) 
        {
            if (parkinglot == null)
            {
                throw new ArgumentNullException(nameof(parkinglot));
            }

            using var context = new DataContext();
            context.Parkinglots.Add(parkinglot);
            context.SaveChanges();
            return "Parkinglot added succesfully";
        }

        public string RemoveParkinglot(Parkinglot parkinglot)
        {
            if (parkinglot == null)
            {
                throw new ArgumentNullException(nameof(parkinglot));
            }

            using var context = new DataContext();
            context.Parkinglots.Remove(parkinglot);
            context.SaveChanges();
            return "Parkinglot delted succesfully";
        }



        public int GetOccupation(Parkinglot parkinglot,DateTime? day) 
        {
            using var context = new DataContext();
            if (day != null)
            {
                DateTime targetDay = day.Value.Date;
                return context.Reservations
                    .Where(p => p.LotId == parkinglot.Id
                                && p.StartDate.Day <= targetDay.Day
                                && p.EndDate.Day >= targetDay.Day)
                    .Count();
            }
            return context.Reservations.Where(p => p.LotId == parkinglot.Id && p.EndDate > DateTime.Now && p.isEnded() == false).Count();

        }

        public List<Parkinglot> GettAllParkingLot() 
        {
            using var context = new DataContext();
            return context.Parkinglots.ToList();
        }


        public List<string> GetVehiclesInLot(Parkinglot p,User u) 
        {
            using var context = new DataContext();
            var userVehicles = context.Vehicles
                .Where(v => v.UserId == u.Id)
                .ToList();

           
            var licensePlates = userVehicles.Select(v => v.LicensePlate).ToList();

            
            var parkedVehicles = context.Reservations
                .Where(r => r.LotId == p.Id
                            && licensePlates.Contains(r.LicensePlate)
                            && (r.EndDate == null || r.EndDate > DateTime.Now)) 
                .Select(r => r.LicensePlate)
                .Distinct()
                .ToList();

            return parkedVehicles;
        }
        
        public List<string> Top5(Parkinglot parkinglot) 
        { 
            using var context = new DataContext();
            var top5Vehicles = context.Reservations
                .GroupBy(r => r.LicensePlate) 
                .Select(group => new
                {
                    Licenseplate = group.Key,
                    Count = group.Count()
                })
                .OrderByDescending(g => g.Count) 
                .Take(5) 
                .Select(g => g.Licenseplate) 
                .ToList();

            return top5Vehicles;
        }

        public string UpdateParkinglot(Parkinglot p) 
        {
            using var context = new DataContext();

            var selectedP = context.Parkinglots.FirstOrDefault(sp => sp.Id == p.Id);

            selectedP.Name = p.Name;
            selectedP.Town = p.Town;
            selectedP.Addres = p.Addres;
            selectedP.Capacity = p.Capacity;
            selectedP.HourlyRate = p.HourlyRate;
            selectedP.PostalCode = p.PostalCode;

            context.Parkinglots.Update(selectedP);
            context.SaveChanges();
            return "Parkinglot updated succesfully";
        }


    }
}
