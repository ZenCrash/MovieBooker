using MovieBooker.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBooker.DataAccess.Dto
{
    public class RoleDto()
    {
        string Id { get; set; }
        string RoleName { get; set; }
        string RoleNameNormalized { get; set; }

        public static RoleDto ToDto(Role role)
        {
            return new RoleDto
            {
                Id = role.Id,
                RoleName = role.Name,
                RoleNameNormalized = role.Name.ToUpper(),
            };
        }
    }
}
