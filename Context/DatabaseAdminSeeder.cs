using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebAppiUsers.Models;

namespace WebAppiUsers.Context
{
    public class DatabaseAdminSeeder
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppUserRole> _roleManager;

        public DatabaseAdminSeeder(UserManager<AppUser> userManager, RoleManager<AppUserRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task Seed()
        {
            var user = await this._userManager.Users.FirstOrDefaultAsync();
            if (user == null)
            {
                await _roleManager.CreateAsync(new AppUserRole { Name = "Admin" });
                await _roleManager.CreateAsync(new AppUserRole { Name = "User" });
                await _roleManager.CreateAsync(new AppUserRole { Name = "Moderator" });

                var admin = new AppUser
                {
                    Email = "admin@example.com",
                    UserName = "admin",
                    EmailConfirmed = true
                };

                var result = await this._userManager.CreateAsync(admin, "Admin@13");

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(admin, "Admin");
                }

            }
        }
    }
}