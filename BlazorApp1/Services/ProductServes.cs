using Shared;

using System.Net.Http.Json;


namespace BlazorApp1.Services
{
    public class ProductServes : BaseServices<Product>
    {
       
        HttpClient httpclient;
        public ProductServes(HttpClient httpclient)//request from service provider
        {
            this.httpclient = httpclient;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetAll()
        {
            List<Product> products =await httpclient.GetFromJsonAsync<List<Product>>("api/Products/");
            return products;
        }

        public async Task<Product> GetByID(int id)
        {
               var product = await httpclient.GetFromJsonAsync<Product>("api/Products/" + id);
            return product;
        }

        public async Task Insert(Product item)
        {
            await httpclient.PutAsJsonAsync<Product>("/api/Products/", item);
        }

        public  async Task Update(int id, Product item)
        {
            await httpclient.PutAsJsonAsync<Product>("/api/Products/" + id, item);

        }
    }
}
