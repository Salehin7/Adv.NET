using BLL.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;

namespace ScheduleApp.Controllers
{
    public class ScheduleController : ApiController 
    {
        [HttpGet]
        [Route("api/schedules")]
        public HttpResponseMessage Schedules()
        {
            try
            {
                var data = ScheduleService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }


        [HttpGet]
        [Route("api/schedules/{id}")]
        public HttpResponseMessage Schedules(int id)
        {
            try
            {
                var data = ScheduleService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }


        [HttpGet]
        [Route("api/schedules/delete/{id}")]
        public HttpResponseMessage DeleteSchedule(int id)
        {
            var res = ScheduleService.DeleteSchedule(id);
            return Request.CreateResponse(HttpStatusCode.OK, res);

        }

        [HttpGet]
        [Route("api/schedules/create")]

        public HttpResponseMessage CreateSchedule(Schedule s)
        {
            var data = ScheduleService.CreateSchedule(s);
            return Request.CreateResponse(HttpStatusCode.OK, new { Message = data });
        }


        [HttpPut]
        [Route("api/schedules/update/{id}")]
        public HttpResponseMessage UpdateSchedule(Schedule obj)
        {
            var res = ScheduleService.UpdateSchedule(obj);
            return Request.CreateResponse(HttpStatusCode.OK, new { Message = res });
        }
    }
}