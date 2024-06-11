using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MovieBooker.DataAccess.Model;
using System;
using System.Threading.Tasks;

namespace MovieBooker.Client.Logic
{
    public class Seed
    {
        public Seed() 
        { 
            
        }

        //Seed Roles
        public static async Task InitializeRolesAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<Role>>();

            foreach (Roles role in Enum.GetValues(typeof(Roles)))
            {
                var roleExists = await roleManager.RoleExistsAsync(role.ToString());
                if (!roleExists)
                {
                    await roleManager.CreateAsync(new Role(role.ToString()));
                }
            }
        }

        enum Roles
        {
            User,
            CiniemaAdmin,
            Admin,
        }
    }
}
