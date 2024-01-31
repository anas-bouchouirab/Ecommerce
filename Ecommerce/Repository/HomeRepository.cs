using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Data;
using Ecommerce.Models;

namespace Ecommerce.Repository
{
    public class HomeRepository:IHomeRepository
    {
        private readonly ApplicationDbContext _db;

        public HomeRepository(ApplicationDbContext db)
        {
            this._db = db;
        }

        public async Task<IEnumerable<ProductTypes>> Genres()
        {
            return await _db.ProductTypes.ToListAsync();
        }
        public async Task<IEnumerable<Product>> GetProduct(string sTerm = "", int ProductTypesId = 0)
        {   
            sTerm = sTerm.ToLower();
            IEnumerable<Product> Products = await (from Product in _db.Product
                                             join ProductTypes in _db.ProductTypes
                                             on Product.ProductTypeId equals ProductTypes.Id
                                             where string.IsNullOrWhiteSpace(sTerm) || (Product != null && Product.Name.ToLower().StartsWith(sTerm))
                                             select new Product
                                             {
                                                 Id = Product.Id,
                                                 Image = Product.Image,
                                                  
                                                 Name = Product.Name,
                                                 ProductTypeId = Product.ProductTypeId,
                                                 Price = Product.Price,
                                                 ProductTypes = ProductTypes
                                             }
                         ).ToListAsync();
            if (ProductTypesId > 0)
            {

                Products = Products.Where(a => a.ProductTypeId == ProductTypesId).ToList();
            }
            return Products;

        }
    }
}

