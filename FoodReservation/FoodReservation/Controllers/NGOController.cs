using FoodReservation.EF;
using FoodReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodReservation.Controllers
{
    public class NGOController : Controller
    {
        // GET: NGO
        public ActionResult Index()
        {
            FoodReservationSystemEntities db = new FoodReservationSystemEntities();
            List<CollectRequest> collectRequestList = db.CollectRequests.ToList();
            CollectRequestDTOModel collectRequestDTOModel = new CollectRequestDTOModel();

            List< CollectRequestDTOModel > collectList = collectRequestList.Select(x=>new CollectRequestDTOModel
            {
                RequestID = x.RequestID,
                RestaurantName = x.Restaurant.RestaurantName,
                EmployeeName = x.Employee.EmployeeName,
                MaxPreservationTime = x.MaxPreservationTime,
                Status = x.Status,
                RequestDate = x.RequestDate
            }).ToList();
            return View(collectList);
        }
    }
}