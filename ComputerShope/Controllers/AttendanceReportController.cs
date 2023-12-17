using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ComputerShope.Controllers
{
    public class AttendanceReportController : ApiController
    {
        [HttpGet]
        [Route("api/AttendanceReport")]

        public HttpResponseMessage AttendanceReports()
        {
            try
            {
                var data = AttendanceReportService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/AttendanceReport/{id}")]

        public HttpResponseMessage AttendanceReports(int id )
        {
            try
            {
                var data = AttendanceReportService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }



    }
}
