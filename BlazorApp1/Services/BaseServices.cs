namespace BlazorApp1.Services
{
    public interface BaseServices<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetByID(int id);
        Task Insert(T item);
        Task Update(int id, T item);
        Task Delete(int id);
    }
}
