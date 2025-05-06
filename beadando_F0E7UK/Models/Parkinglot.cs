using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Parkinglot
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public string Town { get; set; }
        public string Addres { get; set; }
        public int Capacity { get; set; } 
        public int HourlyRate { get; set; }


        public override string ToString()
        {
            return Name;
        }

    }
}
