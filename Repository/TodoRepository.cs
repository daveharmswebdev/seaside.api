using seaside.api.Contracts;
using seaside.api.Data;
using seaside.api.Entities;

namespace seaside.api.Repository
{
    public class TodoRepository : GenericRepository<Todo>, ITodoRepository
    {
        public TodoRepository(SeasideContext context): base(context)
        {
            
        }
    }
}