using System;
using System.Collections.Generic;
using System.Text;
using BlogCMS.Entites.Conrete;
using Microsoft.EntityFrameworkCore;

namespace BlogCMS.Core
{
    class BlogCMSContext : DbContext
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
                Logo = "Logo Adresiniz.",
                Icon = "iconunuz",
                Url = "URL Buraya",
                Description = "Site Açıklaması Burada",
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

        }

        public DbSet<Authorization> Authorizations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }


 
    }
}
