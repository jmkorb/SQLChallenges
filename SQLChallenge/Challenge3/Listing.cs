using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenge.Challenge3
{
    public class Listing
    {
        public int ListingId { get; set; }
        public DateTime DateListed { get; set; }
        public bool IsRental { get; set; }
        public int HouseId { get; set; }
    }
}
