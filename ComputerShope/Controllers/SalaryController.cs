using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ComputerShope.Controllers
{
    public class SalaryController : ApiController
    {
        [HttpGet]
        [Route("api/salary")]

        public HttpResponseMessage Salary()
        {
            try
            {
                var data = SalaryService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);


            }
            catch (Exception ex) 
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });

            }
        }

        [HttpGet]
        [Route("api/salary/{id}")]

        public HttpResponseMessage SelesReport(int id)
        {
            try
            {
                var data = SalaryService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
