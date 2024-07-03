namespace ToDoPWA.Domain.Entities;

public class ToDo
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsDone { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsRepeateable { get; set; }
    public string? RepeatCron { get; set; }

    public Guid? ParentId { get; set; }
    public ToDo? Parent { get; set; }
    public ICollection<ToDo>? Children { get; set; }

    public Guid GroupId { get; set; }
    public Group Group { get; set; }

    public DateTime? DueDate { get; set; }
    public DateTime? CompletedDate { get; set; }
    public DateTime? CreationDate { get; set; }

    public Guid? UserId { get; set; }
    public User? User { get; set; }
}