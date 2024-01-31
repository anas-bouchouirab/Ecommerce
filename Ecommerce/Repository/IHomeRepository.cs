using System.Collections.Generic;
using System.Threading.Tasks;
using Ecommerce.Models;

namespace Ecommerce.Repository
{
    public interface IHomeRepository
    {
        Task<IEnumerable<Product>> GetProduct(string sTerm = "", int ProductTypesId = 0);
        Task<IEnumerable<ProductTypes>> Genres();
    }
}
