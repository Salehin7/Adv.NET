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
    public class NoticeController : ApiController
    {
        [HttpGet]
        [Route("api/notices")]
        public HttpResponseMessage Notices()
        {
            try
            {
                var data = NoticeService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/notices/{id}")]
        public HttpResponseMessage Notices(int id)
        {
            try
            {
                var data = NoticeService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/notices/delete/{id}")]
        public HttpResponseMessage DeleteNotice(int id)
        {
            var res = NoticeService.DeleteNotice(id);
            return Request.CreateResponse(HttpStatusCode.OK, res);
        }

        [HttpPost]
        [Route("api/notices/create")]
        public HttpResponseMessage CreateNotice(Notice n)
        {
            var data = NoticeService.CreateNotice(n);
            return Request.CreateResponse(HttpStatusCode.OK, new { Message = data });
        }

        [HttpPut]
        [Route("api/notices/update/{id}")]
        public HttpResponseMessage UpdateNotice(Notice obj)
        {
            var res = NoticeService.UpdateNotice(obj);
            return Request.CreateResponse(HttpStatusCode.OK, new { Message = res });
        }
    }
}
