using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public  class Review
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string review { get; set; }
        [Required]
        public DateTime Date { get; set; }
       
        public int Pid { get; set; }
        [ForeignKey("Pid")]
        public Product product { get; set; }



        public virtual ICollection<FeedBack> FeedBacks { get; set; }

     

        public Review()
        {
           
            FeedBacks = new List<FeedBack>();
        }
    }
}
