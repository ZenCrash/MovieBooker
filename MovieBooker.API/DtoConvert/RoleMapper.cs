using MovieBooker.API.Dto;
using MovieBooker.DataAccess.Model;

namespace MovieBooker.API.DtoConvert
{
    public static class RoleMapper
    {
        public static RoleDto ToDto(this Role model)
        {
            return new RoleDto
            {
                Id = model.Id,
                RoleName = model.Name,
            };
        }

        public static Role ToModel(this RoleDto dto)
        {
            return new Role
            {
                Id = dto.Id,
                Name = dto.RoleName
            };
        }
    }
}
