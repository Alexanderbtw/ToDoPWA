namespace ToDoPWA.Domain.Entities;

public class Category // Tag
{
    public string Id { get; set; }
    public required string Title { get; set; }
    public string Color { get; set; } = "#FF0000"; // TODO: default color from config
}