using MauiAppBlazor.Models.Enums;

namespace MauiAppBlazor.Models
{
    public class ProductCatalogDto
    {
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public float Price { get; set; }
        public ProductType Type { get; set; }

    }
}
