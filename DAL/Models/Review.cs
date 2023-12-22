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
        public int Id { get; set; }
        [Required]
        public string ReviewDatas { get; set; }
        public DateTime Date { get; set; }
        [Required]
        [ForeignKey("Product")]
        public int Pid { get; set; }

        public virtual Product Product { get; set; }

       public virtual ICollection<FeedBack> FeedBacks { get; set;}

        public Review() 
        {
            FeedBacks = new List<FeedBack>();
        }
    }
}
