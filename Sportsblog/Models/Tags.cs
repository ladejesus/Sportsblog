using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sportsblog.Models
{
    public class Tags
    { 
        [Key]
        public int TagId { get; set; }
        public string TagName { get; set; }

        public virtual List<Posts> Posts { get; set; }

        public Tags()
        {

        }

        
    }

}
