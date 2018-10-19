using System;
using System.Collections.Generic;
using System.Text;
using BlogCMS.Entites.Abstract;

namespace BlogCMS.Entites.Conrete
{
    public class Post : BaseEntity
    {
        public string Name { get; set; }
        public string Shortly { get; set; }
        public string Content { get; set; }
        public string Cover { get; set; }
        public string Icon { get; set; }

        
        public User User { get; set; }

        
        public Menu Menu { get; set; }

    }
}
