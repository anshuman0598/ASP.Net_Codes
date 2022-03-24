using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_DEMO_.Models
{
    public class product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}