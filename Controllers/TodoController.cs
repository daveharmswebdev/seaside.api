using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using seaside.api.Contracts;
using seaside.api.Dtos;
using seaside.api.Entities;

namespace seaside.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoRepository _todoRepository;
        private readonly IMapper _mapper;

        public TodoController(ITodoRepository todoRepository, IMapper mapper)
        {
            _todoRepository = todoRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<TodoDto>>> GetTodos()
        {
            var todos = await _todoRepository.GetAllAsync();
            var todoDtos = _mapper.Map<List<TodoDto>>(todos);

            return Ok(todoDtos);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<TodoDto>> GetById([FromRoute] int id)
        {
            var todo = await _todoRepository.GetAsync(id);
            return Ok(_mapper.Map<TodoDto>(todo));
        }

        [HttpPost]
        public async Task<ActionResult<TodoDto>> CreateTodo([FromBody] CreateTodoDto createTodoDto)
        {
            var newTodo = _mapper.Map<Todo>(createTodoDto);
            
            newTodo.CreatedAt = DateTime.Now;
            newTodo.ModifiedAt = DateTime.Now;
            var createdTodo = await _todoRepository.AddAsync(newTodo);

            return Ok(createdTodo);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult> UpdateTodo([FromBody] UpdateTodoDto updateTodoDto, [FromRoute] int id)
        {
            var todo = await _todoRepository.GetAsync(id);

            if (todo == null)
            {
                return NotFound();
            }

            todo.Name = updateTodoDto.Name;
            todo.Complete = updateTodoDto.Complete;
            todo.ModifiedAt = DateTime.Now;
            await _todoRepository.UpdateAsync(todo);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteTodo([FromRoute] int id)
        {
            var todo = await _todoRepository.GetAsync(id);

            if (todo == null)
            {
                return NotFound();
            }

            await _todoRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}