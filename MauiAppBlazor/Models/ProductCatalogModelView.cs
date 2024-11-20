using MauiAppBlazor.Models.Enums;

namespace MauiAppBlazor.Models
{
    public class ProductCatalogModelView
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public float Price { get; set; }
        public double TotalPrice { get; set; }
        public int Amount { get; set; }
        public ProductType Type { get; set; }
    }
}
