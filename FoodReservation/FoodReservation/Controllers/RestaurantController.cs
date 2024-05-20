using FoodReservation.EF;
using FoodReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodReservation.Controllers
{
    public class RestaurantController : Controller
    {
        public ActionResult Index()
        {
            FoodReservationSystemEntities db = new FoodReservationSystemEntities();
            List<Restaurant> restaurantList = db.Restaurants.ToList();
            RestaurantDTOModel restaurentDTOModel = new RestaurantDTOModel();

            List<RestaurantDTOModel> restaurrant = restaurantList.Select(x => new RestaurantDTOModel
            {
                RestaurantName = x.RestaurantName,
                RestaurantID = x.RestaurantID,
                Location = x.Location,
                Contact = x.Contact
            }).ToList();


            return View(restaurrant);
        }

        [HttpGet]
        public ActionResult AddFoodCollectionRequest()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddFoodCollectionRequest(CollectRequestDTOModel model)
        {
           if(ModelState.IsValid)
            {
                FoodReservationSystemEntities db = new FoodReservationSystemEntities();
                CollectRequest collectRequest = new CollectRequest();

                /*collectRequest.RestaurantID = model.RestaurantID;*/
                collectRequest.MaxPreservationTime = model.MaxPreservationTime;
                collectRequest.RequestDate = model.RequestDate;
                collectRequest.Status = model.Status;
                collectRequest.EmployeeID = model.EmployeeID;
                collectRequest.RestaurantID = model.RestaurantID;
                collectRequest.RequestID = model.RequestID;


                db.CollectRequests.Add(collectRequest);
                db.SaveChanges();

                /*int latestCollectID = collectRequest.RequestID;*/

                return RedirectToAction("../ngo/Index");
            }
           return View();
        }
    }
}