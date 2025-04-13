using MediatR;
using Microsoft.AspNetCore.Mvc;
using Todo.Application.Dto;
using Todo.Application.Features.Todo.Commands;
using Todo.Application.Features.Todo.Queries;

namespace Todo.API.Controllers;

[ApiController]
[Route("api/todo")]
public class TodoController(ISender sender) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateTodoDto dto)
    {
        await sender.Send(new CreateTodoCommand(dto.Title));
        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult<TodoDto[]?>> GetAll()
    {
        var todos = await sender.Send(new AllTodosQuery());
        return todos;
    }
}