using System;
using System.Collections.Generic;
using System.Text;
using BlogCMS.Entites.Conrete;
using Microsoft.EntityFrameworkCore;

namespace BlogCMS.Core
{
    public class BlogCMSContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=BlogCMS;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Setting>().HasData(new Setting
            {
                Id = 1,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Copyright = "Ahmet Emin ŞİTe Aittir.",
                Slogan = "Slogan Buraya",
                SiteTitle = "Site Title",
                Logo = "https://upload.wikimedia.org/wikipedia/commons/2/2f/Logo_TV_2015.svg.",
                Url = "URL Buraya",
                Description = "Site Açıklaması Burada",
                Tel1 = "0212 626 4707",
                Tel2 = "0000 000 0000",
                Gsm1 = "0546 245 9882",
                Gsm2 = "0000 000 0000",
                Fax1 = "0000 000 0000",
                Fax2 = "0000 000 0000",
                Mail1 = "sitahmetemin@gmail.com",
                Mail2 = "sitahmetemin@hotmail.com",
                Address = "3.Defne Sok. Yeşilpınar Mah. No:5 Daire:3",
                Country = "İstanbul",
                Province = "Eyüpsultan",
                Maps = "Google Maps",
                Recapctha = "Google Recapctha",
                Analystic = "Google Analytic",
                Facebook = "Facebook Adresiniz",
                Flickr = "Flickr Adresiniz",
                Github = "Github Adresiniz.",
                Google = "Google Adresiniz.",
                Instagram = "Instagram Adresiniz.",
                Linkedin = "Linkedin Adresiniz.",
                Pinterest = "Pinterest Adresiniz.",
                Reddit = "Reddit Adresiniz.",
                Snapchat = "Snapchat Adresiniz.",
                Youtube = "Youtube Adresiniz.",
                Whatsapp = "Whatsapp Adresiniz.",
                Tumblr = "Tumblr Adresiniz.",
                Twitter = "Twitter Adresiniz.",
                SMTPHost = "Host",
                SMTPPassword = "Pass",
                SMTPPort = "Port",
                SMTPUser = "User"
            });

            modelBuilder.Entity<Authorization>().HasData(
                new Authorization()
                {
                    Id = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "SuperAdmin",
                },
                new Authorization()
                {
                    Id = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Admin",
                },
                new Authorization()
                {
                    Id = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Author",
                });

            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                AuthorizationId = 1,
                Name = "Ahmet Emin ŞİT",
                Email = "sitahmetemin@gmail.com",
                Password = "123654",
            });
        }

        public DbSet<Authorization> Authorizations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}