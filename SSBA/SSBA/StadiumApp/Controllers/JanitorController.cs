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
    public class JanitorController : ApiController
    {
        [HttpGet]
        [Route("api/janitors")]
        public HttpResponseMessage Janitors()
        {
            try
            {
                var data = JanitorService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }


        [HttpGet]
        [Route("api/janitors/{id}")]
        public HttpResponseMessage Janitors(int id)
        {
            try
            {
                var data = JanitorService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }


        [HttpGet]
        [Route("api/janitors/delete/{id}")]
        public HttpResponseMessage DeleteStadium(int id)
        {
            var res = JanitorService.DeleteStadium(id);
            return Request.CreateResponse(HttpStatusCode.OK, res);

        }

        [HttpGet]
        [Route("api/janitors/create")]

        public HttpResponseMessage CreateStadium(Janitor s)
        {
            var data = JanitorService.CreateStadium(s);
            return Request.CreateResponse(HttpStatusCode.OK, new { Message = data });
        }


        [HttpPut]
        [Route("api/janitors/update/{id}")]
        public HttpResponseMessage UpdateStadium(Janitor obj)
        {
            var res = JanitorService.UpdateStadium(obj);
            return Request.CreateResponse(HttpStatusCode.OK, new { Message = res });
        }
    }
}
