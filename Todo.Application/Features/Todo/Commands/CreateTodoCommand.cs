using MediatR;

namespace Todo.Application.Features.Todo.Commands;

public class CreateTodoCommand(string Title): IRequest;