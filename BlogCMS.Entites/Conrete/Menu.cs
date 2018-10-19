using System;
using System.Collections.Generic;
using System.Text;
using BlogCMS.Entites.Abstract;

namespace BlogCMS.Entites.Conrete
{
    public class Menu : BaseEntity
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Cover { get; set; }
        public int? Order  { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public Menu ParentMenu { get; set; }

    }
}
