using System.ComponentModel.DataAnnotations;

namespace Todo.Domain.Entities;

public class Todo
{
    [Key]
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "Title is required")]
    [MaxLength(30, ErrorMessage = "Todo Title must be 30 or less characters.")]
    public string Title { get; set; } = string.Empty;
}