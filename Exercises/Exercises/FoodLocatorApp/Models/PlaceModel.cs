using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.FoodLocatorApp.Models
{
    public class PlaceModel
    {
        public int id { get; set; }
        public string RestaurantImage { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantFood { get; set; }
        public string RestaurantDetail { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}
