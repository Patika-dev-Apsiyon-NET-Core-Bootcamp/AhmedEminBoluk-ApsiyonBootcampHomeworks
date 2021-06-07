using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Models
{
    public class Category
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
