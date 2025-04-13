using Todo.Domain.Contracts;
using Todo.Infrastructure.Context;

namespace Todo.Infrastructure.Repositories;

public class TodoRepository(ApplicationDbContext context) : BaseRepository<Domain.Entities.Todo>(context), ITodoRepository;