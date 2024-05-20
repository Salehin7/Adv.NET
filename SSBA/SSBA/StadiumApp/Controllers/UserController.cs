using BLL.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StadiumApp.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("api/users")]
        public HttpResponseMessage Users()
        {
            try
            {
                var data = UserService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/users/{id}")]
        public HttpResponseMessage Users(string id)
        {
            try
            {
                var data = UserService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/users/delete/{id}")]
        public HttpResponseMessage DeleteUser(string id)
        {
            var res = UserService.DeleteUser(id);
            return Request.CreateResponse(HttpStatusCode.OK, res);
        }

        [HttpPost]
        [Route("api/users/create")]
        public HttpResponseMessage CreateUser(User u)
        {
            var data = UserService.CreateUser(u);
            return Request.CreateResponse(HttpStatusCode.OK, new { Message = data });
        }

        [HttpPut]
        [Route("api/users/update/{id}")]
        public HttpResponseMessage UpdateUser(User obj)
        {
            var res = UserService.UpdateUser(obj);
            return Request.CreateResponse(HttpStatusCode.OK, new { Message = res });
        }
    }
}
