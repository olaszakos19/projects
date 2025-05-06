using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BannedHandler
    {
        public string BanVehicle(Banned banned)
        {
            if (banned == null)
            {
                throw new ArgumentNullException(nameof(banned));
            }

            using var context = new DataContext();

            //lehet át kellene dolgozni
            context.Attach(banned.vehicle);
            context.Attach(banned.parkinglot);

            context.BannedList.Add(banned);
            context.SaveChanges();
            return $"Vehicle with this licenseplate {banned.vehicle.LicensePlate} is banned from this {banned.parkinglot.Name} parkinglot";
        }

        public string UnBanVehicle(Banned banned)
        {
            if (banned == null)
            {
                throw new ArgumentNullException(nameof(banned));
            }

            using var context = new DataContext();
            context.BannedList.Remove(banned);
            context.SaveChanges();
            return $"Vehicle with this licenseplate {banned.vehicle.LicensePlate} is unbanned from this {banned.parkinglot} parkinglot";
        }

        public List<Banned> BannedVehiclesInLot(Parkinglot p)
        {
            //lehet át kell írni
            using var context = new DataContext();
            var bannedVehiclesInParkinglot = context.BannedList
                .Include(b => b.vehicle)
                .Include(b => b.parkinglot)
                .Where(b => b.parkinglot.Id == p.Id)
                .ToList();

            return bannedVehiclesInParkinglot;
        }


    }
}
