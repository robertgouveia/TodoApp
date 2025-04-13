using MediatR;
using Todo.Application.Features.Todo.Commands;

namespace Todo.Application.Features.Todo.Handlers;

public class CreateTodoCommandHandler : IRequestHandler<CreateTodoCommand>
{
    public Task Handle(CreateTodoCommand request, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}