using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Models
{
    public class Blog
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
