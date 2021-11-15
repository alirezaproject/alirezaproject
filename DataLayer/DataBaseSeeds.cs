using System;
using DataLayer.Entities.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public static class DataBaseSeeds
    {
        public static void SeedUsers(ModelBuilder builder)
        {


            var user = new User()
            {
                Id = 1,
                UserName = "shekoohianproject@gmail.com",
                Email = "shekoohianproject@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "09172638641",
                EmailConfirmed = true,
                InsertTime = DateTime.Now,
                SecurityStamp = Guid.NewGuid().ToString(),
                TwoFactorEnabled = false,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                NormalizedEmail = "shekoohianproject@gmail.com".ToUpper(),
                NormalizedUserName = "shekoohianproject@gmail.com".ToUpper(),
                PhoneNumberConfirmed = true,

            };

            var passwordHasher = new PasswordHasher<User>();
            user.PasswordHash = passwordHasher.HashPassword(user, "@lirezaSHE0917");



            builder.Entity<User>().HasData(user);
        }
    }
}