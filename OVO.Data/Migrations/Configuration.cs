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
            var availableManufacturers = context.Manufacturers.ToList();

            var manufacturers = new Manufacturer[]
                {
                    new Manufacturer { Name = "Volkswagen", IsDeleted = false },
                    new Manufacturer { Name = "Audi", IsDeleted = false },
                    new Manufacturer { Name = "Opel", IsDeleted = false },
                    new Manufacturer { Name = "Mercedes", IsDeleted = false },
                    new Manufacturer { Name = "BMW", IsDeleted = false },
                    new Manufacturer { Name = "Toyota", IsDeleted = false },
                    new Manufacturer { Name = "Honda", IsDeleted = false },
                    new Manufacturer { Name = "Mazda", IsDeleted = false },
                    new Manufacturer { Name = "Citroen", IsDeleted = false },
                    new Manufacturer { Name = "Peugeot", IsDeleted = false },
                    new Manufacturer { Name = "Renaut", IsDeleted = false },
                    new Manufacturer { Name = "Other", IsDeleted = false }
                };

            foreach (var man in manufacturers)
            {
                if (availableManufacturers.First(x => x.Name == man.Name) != null)
                {
                    continue;
                }

                context.Manufacturers.AddOrUpdate(man);
            }

            var availableModels = context.Models.ToList();

            var models = 
                new Model[]
                {
                    new Model
                    {
                        Name = "Golf",
                        IsDeleted = false,
                        Manufacturer = manufacturers[0]
                    },
                     new Model
                    {
                        Name = "Passat",
                        IsDeleted = false,
                        Manufacturer = manufacturers[0]
                    },
                     new Model
                    {
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[0]
                    },
                     new Model
                    {
                        Name = "80",
                        IsDeleted = false,
                        Manufacturer = manufacturers[1]
                    },
                     new Model
                    {
                        Name = "100",
                        IsDeleted = false,
                        Manufacturer = manufacturers[1]
                    },
                     new Model
                    {
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[1]
                    },
                     new Model
                    {
                        Name = "Zafira",
                        IsDeleted = false,
                        Manufacturer = manufacturers[2]
                    },
                     new Model
                    {
                        Name = "Omega",
                        IsDeleted = false,
                        Manufacturer = manufacturers[2]
                    },
                     new Model
                    {
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[2]
                    },
                     new Model
                    {
                        Name = "A140",
                        IsDeleted = false,
                        Manufacturer = manufacturers[3]
                    },
                     new Model
                    {
                        Name = "C200",
                        IsDeleted = false,
                        Manufacturer = manufacturers[3]
                    },
                     new Model
                    {
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[3]
                    },
                     new Model
                    {
                        Name = "M3",
                        IsDeleted = false,
                        Manufacturer = manufacturers[4]
                    },
                     new Model
                    {
                        Name = "M5",
                        IsDeleted = false,
                        Manufacturer = manufacturers[4]
                    },
                     new Model
                    {
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[4]
                    },
                     new Model
                    {
                        Name = "Avensis",
                        IsDeleted = false,
                        Manufacturer = manufacturers[5]
                    },
                     new Model
                    {
                        Name = "Corolla",
                        IsDeleted = false,
                        Manufacturer = manufacturers[5]
                    },
                     new Model
                    {
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[5]
                    },
                     new Model
                    {
                        Name = "Accord",
                        IsDeleted = false,
                        Manufacturer = manufacturers[6]
                    },
                     new Model
                    {
                        Name = "CR-V",
                        IsDeleted = false,
                        Manufacturer = manufacturers[6]
                    },
                     new Model
                    {
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[6]
                    },
                     new Model
                    {
                        Name = "121",
                        IsDeleted = false,
                        Manufacturer = manufacturers[7]
                    },
                     new Model
                    {
                        Name = "MX-3",
                        IsDeleted = false,
                        Manufacturer = manufacturers[7]
                    },
                     new Model
                    {
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[7]
                    },
                     new Model
                    {
                        Name = "Picasso",
                        IsDeleted = false,
                        Manufacturer = manufacturers[8]
                    },
                     new Model
                    {
                        Name = "Xsara",
                        IsDeleted = false,
                        Manufacturer = manufacturers[8]
                    },
                     new Model
                    {
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[8]
                    },
                     new Model
                    {
                        Name = "306",
                        IsDeleted = false,
                        Manufacturer = manufacturers[9]
                    },
                     new Model
                    {
                        Name = "407",
                        IsDeleted = false,
                        Manufacturer = manufacturers[9]
                    },
                     new Model
                    {
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[9]
                    },
                     new Model
                    {
                        Name = "Laguna",
                        IsDeleted = false,
                        Manufacturer = manufacturers[10]
                    },
                     new Model
                    {
                        Name = "Megane",
                        IsDeleted = false,
                        Manufacturer = manufacturers[10]
                    },
                     new Model
                    {
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[10]
                    },
                     new Model
                    {
                        Name = "Other",
                        IsDeleted = false,
                        Manufacturer = manufacturers[11]
                    }
                };
            
            foreach (var mod in models)
            {
                if (availableModels.First(x => (x.Name == mod.Name && x.Manufacturer.Name == mod.Manufacturer.Name)) != null)
                {
                    continue;
                }

                context.Models.AddOrUpdate(mod);
            }
        }
    }
}
