using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodReservation.Models
{
    public class EmployeeDTOModel
    {
        /*public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Role { get; set; }
        public string Contact { get; set; }

        public string RestaurantName {  get; set; }
        public string Location { get; set; }
        public string RestaurantContact { get; set; }*/


        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Role { get; set; }
        public string Contact { get; set; }

        public string RestaurantName { get; set; }
        public string Location { get; set; }
        public string RestaurantContact { get; set; }
        public string MaxPreservationTime { get; set; }
    }
}