using System;
using System.Data.Entity.Migrations;
using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using OVO.Data.Models;

namespace OVO.Data.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<OVO.Data.OVOMsSqlDbContext>
    {
        private const string AdministratorUserName = "admin@ovo.com";
        private const string AdministratorPassword = "Pass060992*";

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
            this.AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(OVOMsSqlDbContext context)
        {
            this.SeedAdmin(context);
            this.SeedSampleData(context);
        }

        private void SeedAdmin(OVOMsSqlDbContext context)
        {
            if (!context.Roles.Any())
            {
                var roleName = "Admin";
                var secondRoleName = "User";

                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                var role = new IdentityRole { Name = roleName };
                roleManager.Create(role);
                var secondRole = new IdentityRole { Name = secondRoleName };
                roleManager.Create(secondRole);

                var userStore = new UserStore<User>(context);
                var userManager = new UserManager<User>(userStore);
                var user = new User
                {
                    UserName = AdministratorUserName,
                    Email = AdministratorUserName,
                    EmailConfirmed = true,
                    CreatedOn = DateTime.Now
                };

                userManager.Create(user, AdministratorPassword);
                userManager.AddToRole(user.Id, roleName);
            }
        }

        private void SeedSampleData(OVOMsSqlDbContext context)
        {
            var manufacturers = new Manufacturer[]
                {
                    new Manufacturer { Id = Guid.NewGuid(), Name = "Volkswagen", IsDeleted = false },
                    new Manufacturer { Id = Guid.NewGuid(), Name = "Audi", IsDeleted = false },
                    new Manufacturer { Id = Guid.NewGuid(), Name = "Opel", IsDeleted = false },
                    new Manufacturer { Id = Guid.NewGuid(), Name = "Mercedes", IsDeleted = false },
                    new Manufacturer { Id = Guid.NewGuid(), Name = "BMW", IsDeleted = false },
                    new Manufacturer { Id = Guid.NewGuid(), Name = "Toyota", IsDeleted = false },
                    new Manufacturer { Id = Guid.NewGuid(), Name = "Honda", IsDeleted = false },
                    new Manufacturer { Id = Guid.NewGuid(), Name = "Mazda", IsDeleted = false },
                    new Manufacturer { Id = Guid.NewGuid(), Name = "Citroen", IsDeleted = false },
                    new Manufacturer { Id = Guid.NewGuid(), Name = "Peugeot", IsDeleted = false },
                    new Manufacturer { Id = Guid.NewGuid(), Name = "Renaut", IsDeleted = false },
                    new Manufacturer { Id = Guid.NewGuid(), Name = "Other", IsDeleted = false }
                };

            context.Manufacturers.AddOrUpdate(manufacturers);
            
            var models = 
                new Model[]
                {
                    new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Golf",
                        IsDeleted = false,
                        Manufacturer = manufacturers[0]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Passat",
                        IsDeleted = false,
                        Manufacturer = manufacturers[0]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[0]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "80",
                        IsDeleted = false,
                        Manufacturer = manufacturers[1]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "100",
                        IsDeleted = false,
                        Manufacturer = manufacturers[1]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[1]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zafira",
                        IsDeleted = false,
                        Manufacturer = manufacturers[2]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Omega",
                        IsDeleted = false,
                        Manufacturer = manufacturers[2]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[2]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "A140",
                        IsDeleted = false,
                        Manufacturer = manufacturers[3]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "C200",
                        IsDeleted = false,
                        Manufacturer = manufacturers[3]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[3]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "M3",
                        IsDeleted = false,
                        Manufacturer = manufacturers[4]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "M5",
                        IsDeleted = false,
                        Manufacturer = manufacturers[4]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[4]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Avensis",
                        IsDeleted = false,
                        Manufacturer = manufacturers[5]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Corolla",
                        IsDeleted = false,
                        Manufacturer = manufacturers[5]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[5]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Accord",
                        IsDeleted = false,
                        Manufacturer = manufacturers[6]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "CR-V",
                        IsDeleted = false,
                        Manufacturer = manufacturers[6]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[6]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "121",
                        IsDeleted = false,
                        Manufacturer = manufacturers[7]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "MX-3",
                        IsDeleted = false,
                        Manufacturer = manufacturers[7]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[7]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Picasso",
                        IsDeleted = false,
                        Manufacturer = manufacturers[8]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Xsara",
                        IsDeleted = false,
                        Manufacturer = manufacturers[8]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[8]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "306",
                        IsDeleted = false,
                        Manufacturer = manufacturers[9]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "407",
                        IsDeleted = false,
                        Manufacturer = manufacturers[9]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[9]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Laguna",
                        IsDeleted = false,
                        Manufacturer = manufacturers[10]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Megane",
                        IsDeleted = false,
                        Manufacturer = manufacturers[10]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[10]
                    },
                     new Model
                    {
                        Id = Guid.NewGuid(),
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[11]
                    }
                };

            context.Models.AddOrUpdate(models);

        }
    }
}
