using Ecommerce.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
	public interface IUserOrderRepository
	{
		Task<IEnumerable<Order>> UserOrders();
	}
}
