using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StadiumApp.Controllers
{
    public class RevenueController : ApiController
    {
        [HttpGet]
        [Route("api/revenue")]
        public HttpResponseMessage Revenues()
        {
            try
            {
                var data = RevenueService.Get();
                return Request.CreateResponse(HttpStatusCode.OK,data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
