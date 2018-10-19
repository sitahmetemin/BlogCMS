using System;
using System.Collections.Generic;
using System.Text;
using BlogCMS.Entites.Abstract;

namespace BlogCMS.Entites.Conrete
{
    public class Comment : BaseEntity
    {
        public string Content { get; set; }

        
        public User User { get; set; }

        
        public Post Post { get; set; }

        
        public Comment ParentComment { get; set; }
    }
}
