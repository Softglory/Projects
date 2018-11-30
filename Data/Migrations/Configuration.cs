using Model;

namespace Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.DBEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.DBEntities context)
        {
            // static data for testing 
            AddComapny(context);
            AddAccount(context);
            AddRoles(context);
            AddAdmin(context);
        }

        public void AddComapny(DBEntities context)
        {
            Company Company = new Company()
            {
                CompanyId = 1,
                CompanyName = "The Band",
                AboutUs = "We have created a fictional band website. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Address1 = "Chicago, US",
                Address2 = "Alexandria,Egypt",
                Phone1 = "+00 151515",
                Phone2 = "+20 242424",
                Fax = "555222889",
                Email = "the.band@gmail.com",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now
            };

            Company CompExists = context.Companies.FirstOrDefault(r => r.CompanyName == Company.CompanyName);
            if (CompExists == null)
                context.Companies.Add(Company);
        }

        private void AddAccount(DBEntities context)
        {
            List<Account> Accounts = new List<Account>()
            {
                new Account()
                {
                   FirstName = "هاله",
                   LastName = "كامل",
                   CardImage = "Uploads/hala.jpg" ,
                   ProfessionTitle = "مهندس",
                   Phone = "4565885",
                   Location = "تورونتو",
                   CreatedOn = DateTime.Now,
                   ModifiedOn = DateTime.Now,
                   Status = true          

                },
                new Account()
                {
                    FirstName = "سميرة",
                    LastName = "حكوم",
                    CardImage = "Uploads/samira.jpg" ,
                    ProfessionTitle = "سيدة اعمال",
                    Phone = "6321224",
                    Location = "فانكوفر",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    Status = true
                },
                new Account()
                {
                    FirstName = "هيلين",
                    LastName = "جاك",
                    CardImage = "Uploads/helen.jpg" ,
                    ProfessionTitle = "طبيب",
                    Phone = "78588965",
                    Location = "أوتاوا",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    Status = true

                },
                new Account()
                {
                    FirstName = "طاهر",
                    LastName = "حنيف",
                    CardImage = "Uploads/tahir.jpg" ,
                    ProfessionTitle = "رئيس",
                    Phone = "2188214",
                    Location = "مونتريال",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    Status = true
                }
            };

            foreach (Account user in Accounts)
            {
                Account UserExists = context.Accounts.FirstOrDefault(r => r.FirstName == user.FirstName && r.LastName == user.LastName);
                if (UserExists == null)
                    context.Accounts.Add(user);
            }
            context.Commit();
        }

        private void AddRoles(DBEntities context)
        {
            List<IdentityRole> Roles = new List<IdentityRole>()
            {
                new IdentityRole()
                {
                    Name = "Admin"
                }
            };

            foreach (IdentityRole role in Roles)
            {
                IdentityRole RoleExists = context.Roles.FirstOrDefault(r => r.Name == role.Name);
                if (RoleExists == null)
                    context.Roles.Add(role);
            }
            context.Commit();
        }

        private void AddAdmin(DBEntities context)
        {
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var PasswordHash = new PasswordHasher();
            if (!context.Users.Any(u => u.UserName == "admin@admin.net"))
            {
                var user = new ApplicationUser
                {
                    UserName = "admin@admin.net",
                    Email = "admin@admin.net",
                    PasswordHash = PasswordHash.HashPassword("123456")
                };

                UserManager.Create(user);

                IdentityRole ManagerRole = context.Roles.FirstOrDefault(r => r.Name == "Admin");
                UserManager.AddToRole(user.Id, ManagerRole.Id);
            }
        }
    }
}
