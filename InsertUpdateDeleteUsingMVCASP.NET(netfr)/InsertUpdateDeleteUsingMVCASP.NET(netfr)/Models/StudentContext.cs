using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace InsertUpdateDeleteUsingMVCASP.NET_netfr_.Models
{
    public class StudentContext
    {
        public DbSet<Student> Students { get; set; }
    }
}