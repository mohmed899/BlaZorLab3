using Shared;
namespace BlazorApp1.Pages
{
    public partial class  AllProducts
    {
        // IProductRepo ProductRepo;
        public List<Product> products;
        //public AllProducts(IProductRepo ProductRepo)
        //{
        //    this.ProductRepo = ProductRepo;
        //    products = new List<Product>();
        //}
        public AllProducts()
        {
            products = new List<Product>();
        }
        protected override async Task OnInitializedAsync()
        {
            products = await ProductRepo.GetAll();
            await base.OnInitializedAsync();
        }
       
    }
}
