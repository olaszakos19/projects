using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Vehicle
    {

        [Key]
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        public int UserId { get; set; }
        public User Owner { get; set; }

       
        public override string ToString()
        {
            return $"{Brand} {Type}";
        }


    }
}
