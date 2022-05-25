using Microsoft.AspNetCore.Components;
using Shared;

namespace BlazorApp1.Pages
{
    public partial class ProductDetails
    {
        Product pro;
        [Parameter]
        public int id { get; set; }
      
        protected override async Task OnInitializedAsync()
        {
            pro = await proRepo.GetByID(id);
            await base.OnInitializedAsync();
        }
    }
}
