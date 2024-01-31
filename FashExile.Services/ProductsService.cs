using FashExile.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashExile.Services
{
    public class ProductsService : IProductService
    {
        public void Create(string description, int quantity, string category, decimal price, string discount)
        {
            throw new NotImplementedException();
        }

        public void Delete(string productName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductViewModel> SearchByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductViewModel> SearchByName(string productName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductViewModel> SearchByPrice(int minPrice, int maxPrice)
        {
            throw new NotImplementedException();
        }

        public void UpdateQuantity(string productName, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
