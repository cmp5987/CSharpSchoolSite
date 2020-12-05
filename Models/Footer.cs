using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project3.Models
{
    public class Footer
    {
        public Info social { set; get; }
        public List<QuickLink> quickLinks { set; get; }
        public Copyright copyright { set; get; }
        public String news { set; get; }
    }

    public class Info
    {
        public String title { set; get; }
        public String tweet { set; get; }
        public String by { set; get; }
        public String twitter { set; get; }
        public String facebook { set; get; }
    }

    public class QuickLink
    {
        public String title { set; get; }
        public String href { set; get; }
    }

    public class Copyright
    {
        public String title { set; get; }
        public String html { set; get; }
    }

}
