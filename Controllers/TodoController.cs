using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using seaside.api.Contracts;
using seaside.api.Dtos;
using seaside.api.Entities;

namespace seaside.api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoRepository _todoRepository;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _contextAccessor;

        public TodoController(ITodoRepository todoRepository, IMapper mapper, IHttpContextAccessor contextAccessor)
        {
            _todoRepository = todoRepository;
            _mapper = mapper;
            _contextAccessor = contextAccessor;
        }

        [HttpGet]
        [RequiredScope("todos.read")]
        public async Task<ActionResult<List<TodoDto>>> GetTodos()
        {
            if (_contextAccessor.HttpContext != null)
            {
                var name = _contextAccessor.HttpContext.User.Identity?.Name;
                var email = _contextAccessor.HttpContext.User.Claims.FirstOrDefault(c => c.Type == "emails")?.Value;
                var id = _contextAccessor.HttpContext.User.Claims.FirstOrDefault(c => c.Type == "http://schemas.microsoft.com/identity/claims/objectidentifier")?.Value;
            }
            
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