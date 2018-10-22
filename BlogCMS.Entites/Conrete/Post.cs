using System;
using System.Collections.Generic;
using System.Text;
using BlogCMS.Entites.Abstract;

namespace BlogCMS.Entites.Conrete
{
    public class Post : BaseEntity
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Shortly { get; set; }
        public string Content { get; set; }
        public string Video { get; set; }
        public string Cover { get; set; }
        public string Icon { get; set; }
        public int Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }

        public int? MenuId { get; set; }
        public Menu Menu { get; set; }

    }
}
