using Todo.Infrastructure.Context;

namespace Todo.Infrastructure.Repositories;

public abstract class BaseRepository<T>(ApplicationDbContext context) where T : class
{
    public async Task Create(T entity) => await context.Set<T>().AddAsync(entity);

    public async Task Save() => await context.SaveChangesAsync();
}