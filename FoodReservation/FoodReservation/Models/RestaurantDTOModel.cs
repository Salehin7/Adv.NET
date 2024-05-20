using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodReservation.Models
{
    public class RestaurantDTOModel
    {
        [Required]
        public int RestaurantID { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Contact { get; set; }
    }
}