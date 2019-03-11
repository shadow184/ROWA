﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rowa.repository
{
    public class PageVisit
    {
        public int Id { get; set; }

        [Required]
        public string Url { get; set; }

        public int VisitCount { get; set; }

        public string IpAddress { get; set; }
    }
}
