using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using swebapi.Models;
using System.Runtime.CompilerServices;

namespace swebapi.Data.Seed
{
    public static class SeedIdentityUserData
    {
        public static void SeedUserIdentityData(this ModelBuilder modelBuilder)
        {
            //agregar el rol "Administrador" a tabla AspNetRoles
            string AdministradorGeneralRoleId = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = AdministradorGeneralRoleId,
                Name = "Administrador",
                NormalizedName = "Administrador".ToUpper()
            });

            //Agregar el rol "usuario general" a la tabla AspNetRoles
            string UsuarioGeneralRoleId = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = UsuarioGeneralRoleId,
                Name = "Usuario general",
                NormalizedName = "Usuario general".ToUpper()
            });
            //Agregamos un usuario a la tabla AspNetUsers
            var UsuarioId = Guid.NewGuid().ToString();
            modelBuilder.Entity<CustomIdentityUser>().HasData(
                new CustomIdentityUser
                {
                    Id = UsuarioId,
                    UserName = "gvera@uv.mx",
                    Email = "gvera@uv.mx",
                    NormalizedEmail = "gvera@uv.mx".ToUpper(),
                    Nombre = "Guillermo Humberto Vera Amaro",
                    NormalizedUserName = "gvera@uv.mx".ToUpper(),
                    PasswordHash = new PasswordHasher<CustomIdentityUser>().HashPassword(null, "gverapwd")
                }
            );
            //aplicamos la relación entre el usuario y el rol en la tabla
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = AdministradorGeneralRoleId,
                    UserId = UsuarioId
                }
            );
            //agregamos otros usuarios
            UsuarioId = Guid.NewGuid().ToString();
            modelBuilder.Entity<CustomIdentityUser>().HasData(
                new CustomIdentityUser
                {
                    Id = UsuarioId,
                    UserName = "sperez@uv.mx",
                    Email = "sperez@uv.mx",
                    NormalizedEmail = "sperez@uv.mx".ToUpper(),
                    Nombre = "Saúl Pérez García",
                    NormalizedUserName = "sperez@uv.mx".ToUpper(),
                    PasswordHash = new PasswordHasher<CustomIdentityUser>().HashPassword(null, "saulpwd")
                }
            );
            //aplicamos la relación entre el usuario y el rol en la tabla
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = AdministradorGeneralRoleId,
                    UserId = UsuarioId
                }
            );
            //agregamos otros usuarios
            UsuarioId = Guid.NewGuid().ToString();
            modelBuilder.Entity<CustomIdentityUser>().HasData(
                new CustomIdentityUser
                {
                    Id = UsuarioId,
                    UserName = "gochoa@uv.mx",
                    Email = "gochoa@uv,mx",
                    NormalizedEmail = "gochoa@uv.mx".ToUpper(),
                    Nombre = "Gerardo Ochoa Martínez",
                    NormalizedUserName = "gochoa@uv.mx".ToUpper(),
                    PasswordHash = new PasswordHasher<CustomIdentityUser>().HashPassword(null, "gerapwd")
                }
            );
            //aplicamos la relación entre el usuario y el rol en la tabla
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = UsuarioGeneralRoleId,
                    UserId = UsuarioId
                }
            );
        }
    }
}
