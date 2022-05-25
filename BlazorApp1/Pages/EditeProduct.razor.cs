using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Shared;
namespace BlazorApp1.Pages
{
    public partial class EditeProduct
    {
        [Parameter]
        public int id { get; set; }
        public Product product { get; set; }
        public List<Category> categories { get; set; }

       

        protected override async Task OnInitializedAsync()
        {
            product = await proRepo.GetByID(id);
            categories = await Catrepo.GetAll();
            await base.OnInitializedAsync();
        }

        public void Save()
        {
            proRepo.Update(product.Id, product);
        }
    }
}
