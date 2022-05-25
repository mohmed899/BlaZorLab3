using System.ComponentModel.DataAnnotations.Schema;

namespace Shared
{
    public class Product
    {
        public int Id { get; set; }
        public int price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        [ForeignKey("category")]
        public int CatId { get; set; }
      
        virtual public Category category { get; set; }
    }
}