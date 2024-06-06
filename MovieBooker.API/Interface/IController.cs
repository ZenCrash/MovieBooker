using Microsoft.AspNetCore.Mvc;
using MovieBooker.DataAccess.Model;

namespace MovieBooker.API.Interface
{
    public interface IController<Dto, IdDataType> where Dto : class
    {
        public Task<IEnumerable<Dto>> GetAll();
        public Task<Dto> Get(IdDataType id);
        public Task<bool> Create(Dto dto);
        public Task<bool> Update(Dto dto);
        public Task<bool> Delete(IdDataType id);
    }
}
