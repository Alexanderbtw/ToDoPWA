namespace ToDoPWA.Domain.Entities;

public class ToDoGroupOrder
{
    public string Id { get; set; }

    public string ToDoId { get; set; } // TODO: Index
    public string GroupId { get; set; }

    public string Order { get; set; }
}