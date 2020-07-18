using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string ThumbnailUrl { get; set; }
        public List<Product> Products { get; set; }
    }
}
