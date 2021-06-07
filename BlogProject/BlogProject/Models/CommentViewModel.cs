using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Models
{
    public class CommentViewModel
    {
        public string Description { get; set; }

        public int BlogId { get; set; }

        public int UserId { get; set; }
    }
}
