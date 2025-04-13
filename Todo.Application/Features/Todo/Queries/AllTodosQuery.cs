using MediatR;
using Todo.Application.Dto;

namespace Todo.Application.Features.Todo.Queries;

public class AllTodosQuery : IRequest<TodoDto[]>;