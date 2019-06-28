using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sportsblog.Models
{
    public class Tags
    {
        public string TagName { get; set; }
        public int TagId { get; set; }

        public Tags()
        {
        }

        public Tags(string tagName, string posts, int tagId)
        {
            TagName = tagName;
            TagId = tagId;
        }
    }
}
