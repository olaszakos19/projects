using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Data
{
    public class ReservationHandler
    {


        public string AddReservation(Reservation reservation)
        {
            using var context = new DataContext();

            if (reservation == null)
            {
                throw new ArgumentNullException(nameof(reservation));
            }

            
            if (context.BannedList.Any(b => b.vehicle.LicensePlate == reservation.LicensePlate))
            {
                return "This vehicle is on blacklist,you cannot reserve in this spot!";
            }
            
            bool isOccupied = context.Reservations.Any(r =>
            r.SpotNumber == reservation.SpotNumber &&
            !(reservation.EndDate <= r.StartDate || reservation.StartDate >= r.EndDate));

            if (reservation.StartDate > reservation.EndDate)
            {
                return "A kezdés dátuma nem lehet negyobb a befejezésnél";
            }

            if (isOccupied)
            {
                return "This spot is occupied";
            }

            bool isVehicleReservedElsewhere = context.Reservations.Any(r =>
                                                r.LicensePlate == reservation.LicensePlate &&
                                                !(reservation.EndDate <= r.StartDate || reservation.StartDate >= r.EndDate));

            if (isVehicleReservedElsewhere)
            {
                return "Ez a jármű már foglalt egy másik parkolóban ebben az időszakban!";
            }

            context.Reservations.Add(reservation);
            context.SaveChanges();

            return $"Sikeres foglalás";
        }

        public string UpdateReservation(Reservation updatedReservation)
        {
            using var context = new DataContext();

            if (updatedReservation == null)
            {
                throw new ArgumentNullException(nameof(updatedReservation));
            }

            var existingReservation = context.Reservations
                .FirstOrDefault(r => r.Id == updatedReservation.Id);

            if (existingReservation == null)
            {
                return "A megadott foglalás nem található!";
            }

            bool isOccupied = context.Reservations
                .Any(r => r.Id != updatedReservation.Id &&
                          r.SpotNumber == updatedReservation.SpotNumber &&
                          r.LotId == updatedReservation.LotId &&
                          !(updatedReservation.EndDate <= r.StartDate || updatedReservation.StartDate >= r.EndDate));

            if (isOccupied)
            {
                return "Ez a parkolóhely már foglalt a megadott időszakban!";
            }




            existingReservation.StartDate = updatedReservation.StartDate;
            existingReservation.EndDate = updatedReservation.EndDate;
                                        existingReservation.LicensePlate = updatedReservation.LicensePlate;
            existingReservation.SpotNumber = updatedReservation.SpotNumber;
            existingReservation.LotId = updatedReservation.LotId;

            context.SaveChanges();

            return "Sikeres módosítás!";
        }

        /// <summary>
        /// Lezárja az adott foglalást
        /// </summary>
        public string CloseREservationNow(Reservation reservation)
        {
            using var context = new DataContext();
            if (reservation == null)
            {
                throw new ArgumentNullException(nameof(reservation));
            }

            if (reservation.EndDate < DateTime.Now)
            {
                return "This reservation is already closed";
            }

            reservation.EndDate = DateTime.Now;
            context.Reservations.Update(reservation);
            context.SaveChanges();
            return "Reservation closed";
        }

        //lehet delete
        public int GetCost(Reservation reservation, Parkinglot parkinglot)
        {

            if (reservation == null)
            {
                throw new ArgumentNullException(nameof(reservation));
            }

            TimeSpan duration = DateTime.Now - reservation.StartDate;
            int hours = (int)Math.Ceiling(duration.TotalHours);
            int cost = parkinglot.HourlyRate * hours;

            return cost;
        }

        /// <summary>
        /// Vissza adja a foglalásokat ami a rendszámhoz tartozik
        /// </summary>
        public List<Reservation> GetReservationByLicenseplate(string licensplate)
        {
            using var context = new DataContext();
            return context.Reservations.Where(r => r.LicensePlate == licensplate).ToList();
            
        }

        /// <summary>
        /// Vissza adja a usert megadott foglalás alapján
        /// </summary>
        public User GetUserFromReservation(Reservation reservation)
        {
            using (var context = new DataContext())
            {
                var vehicle = context.Vehicles
                    .FirstOrDefault(v => v.LicensePlate == reservation.LicensePlate);

                if (vehicle == null) return null;

                var user = context.Users
                    .FirstOrDefault(u => u.Id == vehicle.UserId);

                return user;
            }
        }

        /// <summary>
        /// Userhez tartozó foglalások
        /// </summary>
        public List<Reservation> GetReservationByUserId(User user)
        {
            using var context = new DataContext();

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            var vehiclePlates = context.Vehicles
           .Where(v => v.UserId == user.Id)
           .Select(v => v.LicensePlate)
           .ToList();

            var reservations = context.Reservations
                                    .Where(r => vehiclePlates.Contains(r.LicensePlate))
                                    .ToList();

            return reservations;
        }

        /// <summary>
        /// A parkolóhoz tartozó foglalások
        /// </summary>
        public List<Reservation> GetReservationsByLotId(int lotId)
        {
            using var context = new DataContext();

            return context.Reservations.Where(r => r.LotId == lotId).ToList();

        }

        /// <summary>
        /// Vissza adja az összes foglalást
        /// </summary>
        public List<Reservation> GetReservations()
        {
            using var context = new DataContext();

            return context.Reservations.ToList();

        }
        /// <summary>
        /// XML export
        /// </summary>
        public void ExportRevenue(string filePath, int month)
        {
            using var context = new DataContext();


            var reservations = context.Reservations
                .Where(r => r.StartDate.Month == month || r.EndDate.Month == month)
                .ToList();

            if (reservations == null || !reservations.Any())
            {
                throw new InvalidOperationException("Nincs foglalás a megadott hónapban.");
            }


            var root = new XElement("Revenues");
            decimal totalRevenue = 0;

            foreach (var reservation in reservations)
            {

                var parkingLot = context.Parkinglots.FirstOrDefault(p => p.Id == reservation.LotId);
                if (parkingLot == null) continue;


                var reservationDuration = reservation.EndDate - reservation.StartDate;
                int hours = (int)Math.Ceiling(reservationDuration.TotalHours);
                int cost = parkingLot.HourlyRate * hours;
                totalRevenue += cost;

                var reservationElement = new XElement("Reservation",
                    new XElement("LicensePlate", reservation.LicensePlate),
                    new XElement("StartDate", reservation.StartDate.ToString("yyyy-MM-dd HH:mm")),
                    new XElement("EndDate", reservation.EndDate.ToString("yyyy-MM-dd HH:mm")),
                    new XElement("Cost", cost)
                );

                root.Add(reservationElement);
            }


            root.Add(new XElement("TotalRevenue", totalRevenue));
            var document = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), root);
            document.Save(filePath);
        }


    }
}
