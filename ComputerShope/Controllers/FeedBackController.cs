using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ComputerShope.Controllers
{
    public class FeedBackController : ApiController
    {
        /*[HttpGet]
        [Route("api/product/review/{id}")]
        public HttpResponseMessage ProductReview(int id)
        {
            try
            {
                var data = FeedBackService.ProductReview(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }*/
    }
}
