using System;
using System.Collections.Generic;
using System.Text;
using BlogCMS.Entites.Abstract;

namespace BlogCMS.Entites.Conrete
{
    public class Authorization : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
