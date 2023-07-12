using AutoMapper;
using TodoList2.Dto.UserDtos;
using TodoList2.Models;

namespace TodoList2.Profil
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<RegisterDto, User>();

        }
    }
}
