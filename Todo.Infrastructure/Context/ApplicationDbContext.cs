using Microsoft.EntityFrameworkCore;

namespace Todo.Infrastructure.Context;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Domain.Entities.Todo> Todos { get; set; }
}