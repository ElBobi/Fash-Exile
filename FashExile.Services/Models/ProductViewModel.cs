using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashExile.Services.Models
{
    public class ProductViewModel
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }
        public double DiscountPercent { get; set; }
    }
}
