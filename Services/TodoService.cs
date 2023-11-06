using seaside.api.Dtos;

namespace seaside.api.Services
{
    public class TodoService : ITodoService
    {
        public async Task<List<TodoDto>> GetAllTodos()
        {
            throw new NotImplementedException();
        }

        public async Task<TodoDto> GetTodoById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<TodoDto> CreateTodoDto(CreateTodoDto createTodoDto)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateTodoDto(int id, UpdateTodoDto updateTodoDto)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteTodoDto(int id)
        {
            throw new NotImplementedException();
        }
    }
}