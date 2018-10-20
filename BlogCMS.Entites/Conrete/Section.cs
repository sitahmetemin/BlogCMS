using System;
using System.Collections.Generic;
using System.Text;
using BlogCMS.Entites.Abstract;

namespace BlogCMS.Entites.Conrete
{
    public class Section : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Html { get; set; }
        public bool Status { get; set; }
        public string Cover { get; set; }
        
    }
}
