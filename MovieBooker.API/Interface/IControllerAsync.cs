using Microsoft.AspNetCore.Mvc;

namespace MovieBooker.API.Interface
{
    public interface IControllerAsync<DisplayDto, EditDto, IdDataType> where DisplayDto : class
    {
        public Task<IEnumerable<DisplayDto>> GetAll();
        public Task<DisplayDto> Get(IdDataType id);
        public Task<bool> Create(EditDto dto);
        public Task<bool> Update(EditDto dto);
        public Task<bool> Delete(IdDataType id);
    }
}
