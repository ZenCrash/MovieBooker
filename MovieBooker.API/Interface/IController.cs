using Microsoft.AspNetCore.Mvc;
using MovieBooker.DataAccess.Model;

namespace MovieBooker.API.Interface
{
    public interface IController<T, Tid> where T : class
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> Get(Tid id);
        public Task<bool> Create(T dto);
        public Task<bool> Update(T dto);
        public Task<bool> Delete(Tid id);
    }
}
