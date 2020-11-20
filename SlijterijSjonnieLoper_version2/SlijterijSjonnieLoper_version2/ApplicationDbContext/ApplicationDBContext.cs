using Microsoft.AspNet.Identity.EntityFramework;
using SlijterijSjonnieLoper_version2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SlijterijSjonnieLoper_version2.ApplicationDbContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private static ApplicationDbContext _dbContext;
        private ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext GetDbcontext()
        {
            if (_dbContext != null)
            {
                _dbContext = new ApplicationDbContext();
            }
            return _dbContext;
        }

        public DbSet<BestellingModel> bestellingModels { get; set; }

        public DbSet<CustomerModel> customerModels { get; set; }

        public DbSet<EmployeeModel> employeeModels { get; set; }

        public DbSet<WhiskeyModel> whiskeyModels { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}