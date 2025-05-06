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
        private readonly DataContext _context;
        public BannedHandler(DataContext context)
        {
            _context = context;
        }

        public BannedHandler()
        {
            _context = new DataContext();
        }

        public string BanVehicle(Banned banned)
        {
            if (banned == null)
            {
                throw new ArgumentNullException(nameof(banned));
            }

            

            //lehet át kellene dolgozni
            _context.Attach(banned.vehicle);
            _context.Attach(banned.parkinglot);

            _context.BannedList.Add(banned);
            _context.SaveChanges();
            return $"Vehicle with this licenseplate {banned.vehicle.LicensePlate} is banned from this {banned.parkinglot.Name} parkinglot";
        }

        public string UnBanVehicle(Banned banned)
        {
            if (banned == null)
            {
                throw new ArgumentNullException(nameof(banned));
            }


            _context.BannedList.Remove(banned);
            _context.SaveChanges();
            return $"Vehicle with this licenseplate {banned.vehicle.LicensePlate} is unbanned from this {banned.parkinglot} parkinglot";
        }

        public List<Banned> BannedVehiclesInLot(Parkinglot p)
        {
            //lehet át kell írni
            
            var bannedVehiclesInParkinglot = _context.BannedList
                .Include(b => b.vehicle)
                .Include(b => b.parkinglot)
                .Where(b => b.parkinglot.Id == p.Id)
                .ToList();

            return bannedVehiclesInParkinglot;
        }


    }
}
