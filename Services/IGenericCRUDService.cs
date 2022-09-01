namespace DrugStroreAppFull.Services
{
    public interface IGenericCRUDService<T> where T : class
    {
        Task<T> Create(T model);
        Task<T> GetAll();
        Task<T> GetById(int id);
        Task<T> Update(int id, T model);
        Task<bool> Delete(int id);
    }
}
