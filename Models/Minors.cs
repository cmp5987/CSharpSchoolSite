using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project3.Models
{
    public class Minors
    {
        public String name { set; get; }
        public String title { set; get; }
        public String description { set; get; }
        public List<string> courses { get; set; }
    }
}
