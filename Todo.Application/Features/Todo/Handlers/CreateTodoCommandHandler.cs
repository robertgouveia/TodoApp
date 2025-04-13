using MediatR;
using Todo.Application.Features.Todo.Commands;
using Todo.Domain.Contracts;

namespace Todo.Application.Features.Todo.Handlers;

public class CreateTodoCommandHandler(ITodoRepository repo) : IRequestHandler<CreateTodoCommand>
{
    public async Task Handle(CreateTodoCommand request, CancellationToken cancellationToken)
    {
        await repo.Create(new Domain.Entities.Todo
        {
            Title = request.Title
        });

        await repo.Save();
    }
}