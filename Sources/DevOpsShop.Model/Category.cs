using System.ComponentModel.DataAnnotations;

namespace DevOpsShop.Model
{
    public class Category
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}