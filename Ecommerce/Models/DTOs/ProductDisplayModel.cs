using Humanizer.Localisation;

namespace Ecommerce.Models.DTOs
{
	public class ProductDisplayModel
	{
		public IEnumerable<Product> Products { get; set; }
		public IEnumerable<ProductTypes> ProductTypes { get; set; }
		public string STerm { get; set; } = "";
		public int ProductTypesId { get; set; } = 0;
	}
}
