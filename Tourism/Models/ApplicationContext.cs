using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Tourism.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string guideRoleName = "guide";
            string userRoleName = "user";

            string guideEmail = "guide@mail.ru";
            string guidePassword = "123456";
            string guideName = "Тестов Т.Т.";

            // добавляем роли
            Role guideRole = new Role { Id = 1, Name = guideRoleName };
            Role userRole = new Role { Id = 2, Name = userRoleName };
            User guideUser = new User { Id = 1, Name = guideName, Email = guideEmail, Password = guidePassword, RoleId = guideRole.Id };

            modelBuilder.Entity<Role>().HasData(new Role[] { guideRole, userRole });
            modelBuilder.Entity<User>().HasData(new User[] { guideUser });
            base.OnModelCreating(modelBuilder);
        }
    }
}
