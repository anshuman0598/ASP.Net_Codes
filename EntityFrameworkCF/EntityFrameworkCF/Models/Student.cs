﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkCF.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string Mobile { get; set; }
    }
}