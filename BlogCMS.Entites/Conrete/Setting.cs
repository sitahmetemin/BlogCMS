﻿using System;
using System.Collections.Generic;
using System.Text;
using BlogCMS.Entites.Abstract;

namespace BlogCMS.Entites.Conrete
{
    public class Setting : BaseEntity
    {
        public string Url { get; set; }
        public string SiteTitle { get; set; }
        public string Slogan { get; set; }
        public string Description { get; set; }
        public string Copyright { get; set; }
        public string Logo { get; set; }
        public string Icon { get; set; }
        public string SMTPHost { get; set; }
        public string SMTPPort { get; set; }
        public string SMTPUser { get; set; }
        public string SMTPPassword { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Youtube { get; set; }
        public string Linkedin { get; set; }
        public string Google { get; set; }
        public string Github { get; set; }
        public string Pinterest { get; set; }
        public string Tumblr { get; set; }
        public string Flickr { get; set; }
        public string Reddit { get; set; }
        public string Snapchat { get; set; }
        public string Whatsapp { get; set; }
    }
}