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
    public class SponsorController : ApiController
    {
        [HttpGet]
        [Route("api/sponsors")]
        public HttpResponseMessage Sponsors()
        {
            try
            {
                var data = SponsorService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/sponsors/{id}")]
        public HttpResponseMessage Sponsors(int id)
        {
            try
            {
                var data = SponsorService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/sponsors/delete/{id}")]
        public HttpResponseMessage DeleteSponsor(int id)
        {
            var res = SponsorService.DeleteSponsor(id);
            return Request.CreateResponse(HttpStatusCode.OK, res);
        }

        [HttpPost]
        [Route("api/sponsors/create")]
        public HttpResponseMessage CreateSponsor(Sponsor s)
        {
            var data = SponsorService.CreateSponsor(s);
            return Request.CreateResponse(HttpStatusCode.OK, new { Message = data });
        }

        [HttpPut]
        [Route("api/sponsors/update/{id}")]
        public HttpResponseMessage UpdateSponsor(Sponsor obj)
        {
            var res = SponsorService.UpdateSponsor(obj);
            return Request.CreateResponse(HttpStatusCode.OK, new { Message = res });
        }
    }
}
