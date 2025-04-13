using MediatR;

namespace Todo.Application.Features.Todo.Commands;

public record CreateTodoCommand(string Title): IRequest;