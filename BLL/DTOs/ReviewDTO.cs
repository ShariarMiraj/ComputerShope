using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public  class ReviewDTO
    {
        public int Id { get; set; }
        [Required]
        public string ReviewDatas { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public int Pid { get; set; }
    }
}
