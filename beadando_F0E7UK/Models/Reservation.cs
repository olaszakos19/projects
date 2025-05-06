using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Reservation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string LicensePlate { get; set; }


        public int LotId { get; set; }
      

        public int SpotNumber { get; set; }


        public bool isEnded()
        { 
            return EndDate < DateTime.Now;
        }

        public override string ToString()
        {
            return LicensePlate;
        }

    }

}
