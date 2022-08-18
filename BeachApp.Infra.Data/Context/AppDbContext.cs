using BeachApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BeachApp.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }   

        public DbSet<Account> Accounts {get;set;}
        public DbSet<CategoryProduct> CategoryProducts {get;set;}
        public DbSet<Company> Companies {get;set;}
        public DbSet<Employee> Employees {get;set;}
        public DbSet<Product> Products {get;set;}
        public DbSet<Request> Requests {get;set;}
        public DbSet<RequestItens> RequestItens {get;set;}
        public DbSet<Role> Roles {get;set;}
        public DbSet<Sunshade> Sunshades {get;set;}

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);
        //     modelBuilder.Entity<>(x=> {
        //         x.;
        //     });
        // }
    }
}