using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class AttendanceReport
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string EmployeeName { get; set; }
        [Required]
        public DateTime DateTime { get; set; }

        public int Count { get; set; }

        [ForeignKey("Moderator")]
        public int  MId { get; set; }


        public virtual Moderator Moderator { get; set; }
       
    }
}
