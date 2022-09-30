using DevOpsShop.Model;

namespace DevOpsShop.Web.Models
{
    public class ProductViewModel
    {
        public Product Product { get; }

        public ProductViewModel(Product product)
        {
            Product = product;
        }
    }
}
