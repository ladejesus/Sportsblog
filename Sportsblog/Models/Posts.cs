using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sportsblog.Models
{
    public class Posts
    {
        public string Title { get; set; }
        public int PostId { get; set; }
        public string PostContent { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public int SportId { get; set; }
    }
}
