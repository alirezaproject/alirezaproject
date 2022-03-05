using System;
using System.Collections.Generic;
using DataLayer.Entities.Common;
using DataLayer.Entities.SiteAgg;
using DataLayer.Entities.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public static class DataBaseSeeds
    {
        public static void SeedUsers(ModelBuilder builder)
        {
            var site = new object[]
            {
                new
                {
                    LanguageId = 1, Title = "علی رضا شکوهیان", SongAddress = "/audio/music.mp3", SiteId = 1,
                    LogoAddress = "/logo/logo.jpg", InsertTime = DateTime.Now, IsRemoved = false,BackgroundAddress="/img/home-bg.jpg"
                },
                new
                {
                    LanguageId = 2, Title = "alireza shokouhian", SongAddress = "/audio/music.mp3", SiteId = 2,
                    LogoAddress = "/logo/logo.jpg", InsertTime = DateTime.Now, IsRemoved = false,BackgroundAddress="/img/home-bg.jpg"
                }
            };


            builder.Entity<Site>().HasData(site);


            var languages = new List<Language>()
            {
                new Language() {LanguageId = 1, LangName = "fa-IR"},
                new Language() {LanguageId = 2, LangName = "en-US"},
            };

            builder.Entity<Language>().HasData(languages);

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
            user.PasswordHash = passwordHasher.HashPassword(user, "123456");


            builder.Entity<User>().HasData(user);
        }
    }
}