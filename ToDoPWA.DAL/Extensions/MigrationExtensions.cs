using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ToDoPWA.DAL.Contexts;
using ToDoPWA.Domain.Entities;

namespace ToDoPWA.DAL.Extensions;

public static class MigrationExtensions
{
    public static void ApplyMigrations(this IServiceProvider serviceProvider)
    {
        using IServiceScope scope = serviceProvider.CreateScope();
        scope.ServiceProvider.GetRequiredService<ApplicationDbContext>().Database.Migrate();
    }

    public static async Task AddAdminUserIfNotExists(this IServiceProvider serviceProvider)
    {
        using IServiceScope scope = serviceProvider.CreateScope();
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
        var roleProvider = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        if (userManager.FindByEmailAsync("admin@admin.admin").Result != null) return;

        var admin = new User
        {
            UserName = "admin@admin.admin",
            Email = "admin@admin.admin"
        };
        string[] roles = ["admin", "manager"];

        foreach (var role in roles)
        {
            if (!await roleProvider.RoleExistsAsync(role))
            {
                await roleProvider.CreateAsync(new IdentityRole(role));
            }
        }
        await userManager.CreateAsync(admin, "123456");
        await userManager.AddToRolesAsync(admin, ["admin", "user"]);
    }
}