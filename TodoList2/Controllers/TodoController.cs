using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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

        [HttpGet]
        public async Task<IActionResult> GetAllTodo()
        {
            var task =await _todoRepository.GetAllTodos();

            return Ok(_mapper.Map<IEnumerable<TodoReadDto>>(task));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var todoModel =await _todoRepository.GetTodoById(id);

            if(todoModel == null)
                return NotFound();

            return Ok(_mapper.Map<TodoReadDto>(todoModel));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodo(int id)
        {
            if (id == 0)
                return BadRequest();

           var todoModel= await _todoRepository.GetTodoById(id);

            if(todoModel == null)
                return NotFound();

            _todoRepository.DeleteTodo(todoModel);
            await _todoRepository.SaveChangesAsync();

            return NoContent();

        }

    }
}
