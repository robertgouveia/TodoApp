namespace Todo.Application.Dto;

public class TodoDto
{
    public TodoDto()
    {
    }

    public TodoDto(string title)
    {
        Title = title;
    }

    public string Title { get; set; } = string.Empty;
}