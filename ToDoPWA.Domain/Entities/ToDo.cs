namespace ToDoPWA.Domain.Entities;

public class ToDo
{
    public Guid? ParentId { get; set; }
    public Guid Id { get; set; }
    public string Title { get; set; }
    public bool IsDone { get; set; }

    public ToDo? Parent { get; set; }
    public ICollection<ToDo>? Children { get; set; }
}