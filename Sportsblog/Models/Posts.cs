using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sportsblog.Models
{
    public class Posts
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string PostContent { get; set; }
        public string DateTime { get; set; }
        public int SportId { get; set; }
        public int TagId { get; set; }

        public virtual Sports Sports { get; set; }

        public virtual Tags Tags { get; set; }

        public Posts()
        {

        }


    }
    
    
}
