namespace Todo.Domain.Contracts;

public interface IRepository<in T> where T : class
{
    public Task Create(T entity);

    public Task Save();
}