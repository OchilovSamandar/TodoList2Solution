using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList2.Data;
using TodoList2.Dto;
using TodoList2.Models;
using TodoList2.Profil;

namespace TodoList2.Controllers
{
    [Route("api/todo")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoRepository _todoRepository;

        private readonly IMapper _mapper;

        public TodoController(ITodoRepository todoRepository, IMapper mapper)
        {
            _todoRepository = todoRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTodo(TodoCreateDto todoCreateDto)
        {
            var todoModel = _mapper.Map<Todo>(todoCreateDto);

            await _todoRepository.CreateTodo(todoModel);
            await _todoRepository.SaveChangesAsync();

            var todoReadDto = _mapper.Map<TodoReadDto>(todoModel);

            return Created("Todo yaratildi", todoReadDto);



        }

    }
}
