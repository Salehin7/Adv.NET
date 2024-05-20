using FoodReservation.EF;
using FoodReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodReservation.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult EmployeeDashboard()
        {
            FoodReservationSystemEntities db = new FoodReservationSystemEntities();
            /*List<Employee> employeesList = db.Employees.ToList();*/
            List<CollectRequest> request = db.CollectRequests.ToList();

            EmployeeDTOModel employeeModel = new EmployeeDTOModel();

            List<EmployeeDTOModel> employeeDTOModels = request.Select(x => new EmployeeDTOModel
            {
                EmployeeID = x.EmployeeID,
                EmployeeName = x.Employee.EmployeeName,
                RestaurantName = x.Restaurant.RestaurantName,
                Location = x.Restaurant.Location,
                Contact = x.Restaurant.Contact,
                MaxPreservationTime = x.MaxPreservationTime,


            }).ToList();


            return View(employeeDTOModels);
        }
    }
}