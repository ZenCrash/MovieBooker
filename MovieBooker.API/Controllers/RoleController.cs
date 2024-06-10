using Microsoft.AspNetCore.Mvc;
using MovieBooker.API.Dto;
using MovieBooker.API.Interface;
using MovieBooker.API.Model;
using MovieBooker.API.Repository;

namespace MovieBooker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController
    {
        private RoleRepository _repository { get; init; } = new();
    }
}
