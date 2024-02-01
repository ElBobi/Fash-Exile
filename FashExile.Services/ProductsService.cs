using FashExile.Services.Models;
using FashExile.Models;
using FashExile.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace FashExile.Services
{
    public class ProductsService : IProductService
    {
        private ShoppingDbContext db;
        public ProductsService(ShoppingDbContext db)
        {
            this.db = db;
        }
        public void Create(string description, int quantity, string category, decimal price, string? discount)
        {
            var product = new Product
            {
                Description = description,
                Quantity = quantity,
                Price = price,
            };

            var categoryEntity = this.db.Categories.FirstOrDefault(x => x.Name.Trim() == category.Trim());
            if (categoryEntity == null)
            {
                categoryEntity = new Category { Name = category };
            }
            product.Category = categoryEntity;

            var discountEntity = this.db.Discounts.FirstOrDefault(x => x.Name.Trim() == discount.Trim());
            product.Discount = discountEntity;

            this.db.Products.Add(product);
            this.db.SaveChanges();
        }

        public void Delete(string productName)
        {
            var product = this.db.Products.FirstOrDefault(x => x.Description == productName);
            this.db.Products.Remove(product);
        }

        public IEnumerable<ProductViewModel> SearchByCategory(string categoryName)
        {
            return this.db.Products
                .Where(x => x.Category.Name.Trim() == categoryName)
                .Select(MapToProductViewModel())
                .OrderBy(x => x.CategoryName)
                .ToList();
        }

        public IEnumerable<ProductViewModel> SearchByName(string productName)
        {
            return this.db.Products
                .Where(x => x.Description.Trim() == productName)
                .Select(MapToProductViewModel())
                .OrderBy(x => x.Description)
                .ToList();
        }

        public IEnumerable<ProductViewModel> SearchByPrice(int minPrice, int maxPrice)
        {
            return this.db.Products
            .Where(x => x.Price >= minPrice && x.Price <= maxPrice)
            .Select(MapToProductViewModel())
            .OrderBy(x => x.CategoryName)
            .ToList();
        }

        public void UpdateQuantity(string productName, int quantity)
        {
            var productEntity = this.db.Products.FirstOrDefault(x => x.Description.Trim() == productName.Trim());
            productEntity.Quantity += quantity;
            this.db.SaveChanges();
        }
        private static Expression<Func<Product, ProductViewModel>> MapToProductViewModel()
        {
            return x => new ProductViewModel
            {
                Description = x.Description,
                Quantity = x.Quantity,
                CategoryName = x.Category.Name,
                Price = x.Price,
                DiscountPercent = x.Discount.DiscountPercent,
            };
        }
    }
}
