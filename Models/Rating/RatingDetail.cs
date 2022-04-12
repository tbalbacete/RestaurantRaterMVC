using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantRaterMVC.Models.Rating
{
    public class RatingDetail
    {
        public int Id { get; set; }
        public string RestaurantName { get; set; }
        public double Score { get; set; }
    }
}