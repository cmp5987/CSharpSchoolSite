using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project3.Models
{
    public class Research
    {
        public List<ByInterestArea> byInterestArea { set; get; }
        public List<ByFaculty> byFaculty { set; get; }
    }

    public class ByInterestArea
    {
        public String areaName { set; get; }
        public List<String> citations { set; get; }
    }

    public class ByFaculty
    {
        public String facultyName { set; get; }
        public String username { set; get; }
        public List<String> citations { set; get; }
    }
}
