using BLL.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;

namespace StadiumApp.Controllers
{
    public class EventController : ApiController
    {
        [HttpGet]
        [Route("api/events")]
        public HttpResponseMessage Events()
        {
            try
            {
                var data = EventService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/events/{id}")]
        public HttpResponseMessage Events(int id)
        {
            try
            {
                var data = EventService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/events/delete/{id}")]
        public HttpResponseMessage DeleteEvent(int id)
        {
            var res = EventService.DeleteEvent(id);
            return Request.CreateResponse(HttpStatusCode.OK, res);
        }

        [HttpPost]
        [Route("api/events/create")]
        public HttpResponseMessage CreateEvent(Event e)
        {
            var data = EventService.CreateEvent(e);
            return Request.CreateResponse(HttpStatusCode.OK, new { Message = data });
        }

        [HttpPut]
        [Route("api/events/update/{id}")]
        public HttpResponseMessage UpdateEvent(Event obj)
        {
            var res = EventService.UpdateEvent(obj);
            return Request.CreateResponse(HttpStatusCode.OK, new { Message = res });
        }
    }
}
