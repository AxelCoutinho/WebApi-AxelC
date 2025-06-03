using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApi29AV.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        //Las clases que se van a mapear en la DB

        public DbSet<User> Users { get; set; }
        public DbSet<Rol> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Insertar en tabla Usuario
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    PKUser = 1,
                    Name = "Axel",
                    Username = "Usuario",
                    Password = "123",
                    FKRol = 1 // Aqui debes poner rol correspondiente

                });


            //Insertar en la tabla Roles

            modelBuilder.Entity<Rol>().HasData(
                new Rol
                {
                    PKRol = 1,
                    Name = "a"
                },
                new Rol
                {
                    PKRol = 2,
                    Name = "sa"
                });

        }
    }
}
