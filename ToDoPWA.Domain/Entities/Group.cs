namespace ToDoPWA.Domain.Entities;

public class Group
{
    public string Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public required ICollection<ToDo> ToDos { get; set; }

    public bool IsDeleted { get; set; }

    public string Color { get; set; } = "#000000"; // TODO: default color from config

    public string? ParentId { get; set; }
    public Group? Parent { get; set; }

    public string? UserId { get; set; }
    public User? User { get; set; }
}