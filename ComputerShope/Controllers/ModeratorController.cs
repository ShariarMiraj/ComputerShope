using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ComputerShope.Controllers
{
    public class ModeratorController : ApiController
    {
        [HttpGet]
        [Route("api/Moderator")]

        public HttpResponseMessage Moderators()
        {
            try
            {
                var data = ModeratorService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);


            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });

            }
        }


        [HttpGet]
        [Route("api/Moderator/{id}")]

        public HttpResponseMessage Moderator(int id)
        {
            try
            {
                var data = ModeratorService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/Moderator/{id}/salary")]


        public HttpResponseMessage MSalary(int id)
        {
            try
            {
                var data = ModeratorService.Getwithsalary(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

    }
}
