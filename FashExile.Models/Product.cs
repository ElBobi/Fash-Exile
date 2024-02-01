using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashExile.Models
{
    public class Product
    {
        public Product()
        {
            this.OrderProducts = new HashSet<OrderProduct>();
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public decimal Price { get; set; }
        public int? DiscountId { get; set; }
        public virtual Discount Discount { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ModifiedAt { get; set; } = DateTime.UtcNow;
    }
}
