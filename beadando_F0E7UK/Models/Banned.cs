using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Banned
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Vehicle vehicle { get; set; }

        public string Reason { get; set; }

        public Parkinglot parkinglot { get; set; }
     
        public override string ToString()
        {
            return $"Parkoló: {parkinglot.Name} Jármű:{vehicle.LicensePlate}";
        }
    }

}
