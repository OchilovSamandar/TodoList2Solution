using AutoMapper;
using TodoList2.Dto.TodoDtos;
using TodoList2.Models;

namespace TodoList2.Profil
{
    public class ProfilTodo : Profile
    {

        public ProfilTodo() 
        {
            CreateMap<TodoCreateDto, Todo>().ReverseMap();
            CreateMap<Todo,TodoReadDto>().ReverseMap();
        
        
        
        }
    }
}
