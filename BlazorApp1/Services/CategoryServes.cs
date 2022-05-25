using Shared;

using System.Net.Http.Json;
namespace BlazorApp1.Services
{
    public class CategoryServes : BaseServices<Category>
    {


        HttpClient httpclient;
        public CategoryServes(HttpClient httpclient)//request from service provider
        {
            this.httpclient = httpclient;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public  async Task<List<Category>> GetAll()
        {
            var Categories = await httpclient.GetFromJsonAsync<List<Category>>("/api/Categories");
            return Categories;
        }

        public Task<Category> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(Category item)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Category item)
        {
            throw new NotImplementedException();
        }
    }
}
