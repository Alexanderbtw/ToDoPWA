namespace ToDoPWA.Domain.Entities;

public class ToDo
{
    public string Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public bool IsDone { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsRepeatable { get; set; }
    public string? RepeatTimeCron { get; set; }

    public string? ParentId { get; set; }
    public ToDo? Parent { get; set; }
    public ICollection<ToDo>? Children { get; set; }

    public string? GroupId { get; set; }
    public Group? Group { get; set; } // Default - in "All Tasks" group == ungrouped

    public DateTime? DueDate { get; set; }
    public DateTime? CompletedDate { get; set; }
    public DateTime? CreationDate { get; set; }

    public string? UserId { get; set; }
    public User? User { get; set; }
}