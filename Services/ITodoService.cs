using seaside.api.Dtos;

namespace seaside.api.Services
{
    public interface ITodoService
    {
        Task<List<TodoDto>> GetAllTodos();
        Task<TodoDto> GetTodoById(int id);
        Task<TodoDto> CreateTodoDto(CreateTodoDto createTodoDto);
        Task UpdateTodoDto(int id, UpdateTodoDto updateTodoDto);
        Task DeleteTodoDto(int id);
    }
}