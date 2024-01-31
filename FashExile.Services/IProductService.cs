using FashExile.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashExile.Services
{
    public interface IProductService
    {
        void Create(string description, int quantity, string category, decimal price, string discount);
        void Delete(string productName);
        void UpdateQuantity(string productName, int quantity);
        IEnumerable<ProductViewModel> SearchByName(string productName);
        IEnumerable<ProductViewModel> SearchByPrice(int minPrice, int maxPrice);
        IEnumerable<ProductViewModel> SearchByCategory(string categoryName);

    }
}
