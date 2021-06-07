using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Models
{
    public class Comment
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Description { get; set; }

        public virtual Blog Blog { get; set; }

        public virtual User User { get; set; }
    }
}
