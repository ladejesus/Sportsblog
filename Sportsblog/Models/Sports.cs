﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sportsblog.Models
{
    public class Sports
    {
        public string SportName { get; set; }
        public int SportId { get; set; }       

        public Sports()
        {
        }

        public Sports(string sportName, int sportId)
        {
            SportName = sportName;
            SportId = sportId;
        }

    }

}
