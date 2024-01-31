using System.Threading.Tasks;
using Ecommerce.Models;

namespace Ecommerce.Repository
{
	public interface ICartRepository
	{
		Task<int> AddItem(int productId, int qty);
		Task<int> RemoveItem(int id);
		Task<ShoppingCart> GetUserCart();
		Task<int> GetCartItemCount(string userId = "");
		Task<ShoppingCart> GetCart(string userId);
		Task<bool> DoCheckout();
	}
}