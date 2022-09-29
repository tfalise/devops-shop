using DevOpsShop.Model;

namespace DevOpsShop.Web.Models
{
    public class CatalogViewModel
    {
        public List<Product> Products { get; set; }

        public CatalogViewModel(List<Product> products)
        {
            Products = products;
        }
    }
}
