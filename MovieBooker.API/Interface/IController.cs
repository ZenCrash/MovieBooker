using Microsoft.AspNetCore.Mvc;
using MovieBooker.DataAccess.Model;

namespace MovieBooker.API.Interface
{
    public interface IController<DisplayDto, EditDto, IdDataType> where DisplayDto : class
    {
        public Task<IEnumerable<DisplayDto>> GetAll();
        public Task<DisplayDto> Get(IdDataType id);
        public Task<bool> Create(EditDto dto);
        public Task<bool> Update(EditDto dto);
        public Task<bool> Delete(IdDataType id);
    }
}
