using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sportsblog.Models
{
    public class Sports
    {
        [Key]
        public int SportId { get; set; }
        public string SportName { get; set; }
        public string ImageUrl { get; set; }

        public virtual List<Posts> Posts { get; set; }

       public Sports()
        {

        }

    }

}
