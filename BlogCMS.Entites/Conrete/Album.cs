using System;
using System.Collections.Generic;
using System.Text;
using BlogCMS.Entites.Abstract;

namespace BlogCMS.Entites.Conrete
{
    public class Album : BaseEntity
    {
        public string Way { get; set; }
        public int? Order { get; set; }

        public int? PostId { get; set; }
        public Post Post { get; set; }

        public int? MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}
