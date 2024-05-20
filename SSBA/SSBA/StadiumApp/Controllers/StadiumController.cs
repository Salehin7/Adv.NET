using BLL.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StadiumApp.Controllers
{
    public class StadiumController : ApiController
    {
        [HttpGet]
        [Route("api/stadiums")]
        public HttpResponseMessage Seats()
        {
            try
            {
                var data = StadiumService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }


        [HttpGet]
        [Route("api/stadiums/{id}")]
        public HttpResponseMessage Seats(int id)
        {
            try
            {
                var data = StadiumService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }


        [HttpGet]
        [Route("api/stadiums/delete/{id}")]
        public HttpResponseMessage DeleteStadium(int id)
        {
            var res = StadiumService.DeleteStadium(id);
            return Request.CreateResponse(HttpStatusCode.OK, res);

        }

        [HttpGet]
        [Route("api/stadiums/create")]

        public HttpResponseMessage CreateStadium(Stadium s)
        {
            var data = StadiumService.CreateStadium(s);
            return Request.CreateResponse(HttpStatusCode.OK, new { Message = data });
        }


        [HttpPut]
        [Route("api/stadiums/update/{id}")]
        public HttpResponseMessage UpdateStadium(Stadium obj)
        {
            var res = StadiumService.UpdateStadium(obj);
            return Request.CreateResponse(HttpStatusCode.OK, new { Message = res });
        }

    }
}
