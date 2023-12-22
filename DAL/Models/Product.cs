using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public  class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(15)]
        public string ProductName { get; set; }
        [Required]
        [StringLength(15)]
        public string ProductCategory { get; set; }
        [Required]
        public int ProductPrice { get; set; }
        [Required]
        public int ProdcutQuantity { get; set; }


        public virtual ICollection<Review> Reviews { get; set; }

        public Product()
        {
            Reviews = new List<Review>();
        }
    }
}
