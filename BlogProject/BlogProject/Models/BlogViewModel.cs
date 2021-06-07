using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Models
{
    public class BlogViewModel
    {
        public int Id { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public List<int> SelectedCategories { get; set; }
    }
}
