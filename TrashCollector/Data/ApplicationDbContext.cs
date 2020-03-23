using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Models;

namespace TrashCollector.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Pickup> Pickup { get; set; }
        public DbSet<CustomerView> CustomerView { get; set; }
        public DbSet<EmployeeView> EmployeeView { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                },
                new IdentityRole
                {
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                },
                new IdentityRole
                {
                    Name = "CustomerView",
                    NormalizedName = "CUSTOMERVIEW"
                },
                new IdentityRole
                {
                    Name = "EmployeeView",
                    NormalizedName = "EMPLOYEEVIEW"
                }
               );
        }
    }
}
