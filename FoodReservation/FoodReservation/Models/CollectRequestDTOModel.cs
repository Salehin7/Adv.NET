using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodReservation.Models
{
    public class CollectRequestDTOModel
    {
        public int RequestID { get; set; }
       /* public int RestaurantID { get; set; }
        public int EmployeeID { get; set; }*/
        public string MaxPreservationTime { get; set; }
        public string Status { get; set; }
        public System.DateTime RequestDate { get; set; } //= DateTime.Now;

        public string RestaurantName { get; set; }

        public int RestaurantID { get; set; }

        public int EmployeeID {  get; set; }

        public string Location { get; set; }

        public string contact {  get; set; }
        public string EmployeeName { get; set; }
    }
}