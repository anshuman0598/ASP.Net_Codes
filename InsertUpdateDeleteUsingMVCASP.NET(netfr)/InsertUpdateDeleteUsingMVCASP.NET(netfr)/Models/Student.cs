using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsertUpdateDeleteUsingMVCASP.NET_netfr_.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public string Mobile { get; set; }
    }
}