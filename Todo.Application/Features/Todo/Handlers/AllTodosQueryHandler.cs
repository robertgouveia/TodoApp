using MediatR;
using Todo.Application.Dto;
using Todo.Application.Features.Todo.Queries;

namespace Todo.Application.Features.Todo.Handlers;

public class AllTodosQueryHandler : IRequestHandler<AllTodosQuery, TodoDto[]>
{
    public Task<TodoDto[]> Handle(AllTodosQuery request, CancellationToken cancellationToken)
    {
        var todos = new[]
        {
            new TodoDto(title: "Test 1"),
            new TodoDto(title: "Test 2"),
            new TodoDto(title: "Test 3"),
        };

        return Task.FromResult(todos);
    }
}