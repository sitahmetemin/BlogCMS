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
                SiteTitle = "Site Title Buraya",
                Logo = "https://upload.wikimedia.org/wikipedia/commons/2/2f/Logo_TV_2015.svg",
                Url = "URL Buraya",
                Description = "Site Açıklaması Burada",
                Tel1 = "0212 626 4707",
                Tel2 = "0212 626 4707",
                Gsm1 = "0546 245 9882",
                Gsm2 = "0546 245 9882",
                Fax1 = "0546 245 9882",
                Fax2 = "0546 245 9882",
                Mail1 = "sitahmetemin@gmail.com",
                Mail2 = "sitahmetemin@hotmail.com",
                Address = "3.Defne Sok. Yeşilpınar Mah. No:5 Daire:3",
                Country = "İstanbul",
                Province = "Eyüpsultan",
                Maps = "Google Maps",
                Recapctha = "Google Recapctha",
                Analystic = "Google Analytic",
                Facebook = "https://www.facebook.com/sitahmetemin",
                Flickr = "Flickr Adresiniz",
                Github = "Github Adresiniz.",
                Google = "Google Adresiniz.",
                Instagram = "https://www.instagram.com/sitahmetemin",
                Linkedin = "Linkedin Adresiniz.",
                Pinterest = "Pinterest Adresiniz.",
                Reddit = "Reddit Adresiniz.",
                Snapchat = "Snapchat Adresiniz.",
                Youtube = "https://www.youtube.com/c/ahmet%20emin%20%C5%9Fit",
                Whatsapp = "0546 245 9882",
                Tumblr = "Tumblr Adresiniz.",
                Twitter = "https://twitter.com/sitahmetemin",
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
                Status = 1,
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
        public DbSet<Album> Albums { get; set; }
        public DbSet<Section> Sections { get; set; }
    }
}