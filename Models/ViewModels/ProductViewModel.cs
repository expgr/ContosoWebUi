namespace ContosoWeb.Models.ViewModels
{
    public class ProductViewModel
    {
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public string ProdDetail { get; set; }
        public string ImagePath { get; set; }
        public double Rating { get; set; }
        public decimal Price { get; set; }
    }
}