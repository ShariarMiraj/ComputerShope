using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ComputerShope.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        [Route("api/Product")]
        public HttpResponseMessage Moderators()
        {
            try
            {
                var data = ProductService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);


            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });

            }
        }


        [HttpGet]
        [Route("api/Product/{id}/review")]
        public HttpResponseMessage ProductREview(int id)
        {
            try
            {
                var data = ProductService.GetReView(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }

        }
    }
}
