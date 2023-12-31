﻿using BLL.Services;
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

        [HttpGet]
        [Route("api/Feback")]
        public HttpResponseMessage review()
        {
            try
            {
                var data = FeedBackService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/Product/{id}/reviews")]
        public HttpResponseMessage ProductReview(int  id)
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


        [HttpGet]
        [Route("api/feedback/review/{id}")]
        public HttpResponseMessage UserReview(int id)
        {
            try
            {
                var data = FeedBackService.ReviewFeedBAck(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
