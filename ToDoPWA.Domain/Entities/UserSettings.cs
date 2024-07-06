namespace ToDoPWA.Domain.Entities;

public class UserSettings
{
    public string Id { get; set; }
    public string UserId { get; set; }

    public string RefreshTimeCron { get; set; } = "0 0 * * *";
    public bool IsDarkMode { get; set; }
}