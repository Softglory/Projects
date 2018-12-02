using Data.Configurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Data
{
    public class DBEntities : IdentityDbContext<ApplicationUser>
    {
        public DBEntities() : base("DBEntities", throwIfV1Schema: false)
        {

        }

        #region Entity Sets 
        public IDbSet<Account> Accounts { get; set; }
        public IDbSet<SearchCount> SearchCounts { get; set; }
        public IDbSet<Company> Companies { get; set; }
        public IDbSet<Ad> Ads { get; set; }
        public IDbSet<AccountKeyword> AccountKeywords { get; set; }
        public IDbSet<Service> Services { get; set; }
       // public IDbSet<AccountService> AccountServices { get; set; }

        #endregion

        public static DBEntities Create()
        {
            return new DBEntities();
        }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationUser>().ToTable("Users"); // renaming identity tables
            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims");

            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new AccountConfiguration());
            modelBuilder.Configurations.Add(new SearchCountConfiguration());
            modelBuilder.Configurations.Add(new CompanyConfiguration());
            modelBuilder.Configurations.Add(new AdConfiguration());
            modelBuilder.Configurations.Add(new ServiceConfiguration());
            modelBuilder.Configurations.Add(new AccountServiceConfiguration());


        }

    }
}
