namespace MovieBooker.API.Interface
{
    public interface IRepositoryAsync<Model, IdType> where Model : class
    {
        public Task<IEnumerable<Model>> GetAllAsync();
        public Task<Model> GetByIdAsync(IdType id);
        public Task<bool> CreateAsync(Model entity);
        public Task<bool> UpdateAsync(Model entity);
        public Task<bool> DeleteByIdAsync(IdType id);
    }
}
