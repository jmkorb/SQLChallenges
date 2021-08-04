using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenge.Challenge2
{
    public class Technician
    {
        public int TechnicianId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal CustomerRating { get; set; }
        public int VehicleId { get; set; }
    }
}
