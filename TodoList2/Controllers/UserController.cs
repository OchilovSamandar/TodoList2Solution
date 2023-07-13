using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList2.Data.UserRepo;
using TodoList2.Dto.UserDtos;
using TodoList2.Models;

namespace TodoList2.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserController(IUserRepository userRepository,IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpPost("/register")]
        public async Task<IActionResult> RegisterUser(RegisterDto user)
        {
            if (user == null)
            {
                return NotFound();
            }

            var registerDto = new RegisterDto();
            registerDto.Firstname = user.Firstname;
            registerDto.Lastname = user.Lastname;
            registerDto.Username = user.Username;
            registerDto.Password = user.Password;
            var userModel=_mapper.Map<User> (registerDto);

            await _userRepository.Register(userModel);
            return Created("Hisob yaratildi", userModel);

        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userRepository.GetAllUser();

            return Ok(users);
        }
    }
}
