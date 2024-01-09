using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AttendancePieChartDTO
    {
        public string EmployeeName { get; set; }
        public DateTime DateTime { get; set; }

        public int Count { get; set; }

    }
}
