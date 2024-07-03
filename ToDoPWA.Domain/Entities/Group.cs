namespace ToDoPWA.Domain.Entities;

public class Group
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    ICollection<ToDo> ToDos { get; set; }

    public bool IsDeleted { get; set; }

    public string Color { get; set; }

    public Guid? ParentId { get; set; }
    public Group? Parent { get; set; }

    public Guid? UserId { get; set; }
    public User? User { get; set; }
}