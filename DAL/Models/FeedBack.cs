using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public  class FeedBack
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(150)]
        public string ReviewFeedBack { get; set; }
        [ForeignKey("Review")]
        public int Rid { get; set; }
        

        public Review Review { get; set; }
    }
}
