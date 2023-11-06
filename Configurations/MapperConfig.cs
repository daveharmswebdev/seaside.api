using AutoMapper;
using seaside.api.Dtos;
using seaside.api.Entities;

namespace seaside.api.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Todo, TodoDto>().ReverseMap();
            CreateMap<Todo, CreateTodoDto>().ReverseMap();
            CreateMap<Todo, UpdateTodoDto>().ReverseMap();
        }
    }
}