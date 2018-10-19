using System;
using System.Collections.Generic;
using System.Text;
using BlogCMS.Entites.Abstract;

namespace BlogCMS.Entites.Conrete
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int? AuthorizationId { get; set; }
        public Authorization Authorization { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
