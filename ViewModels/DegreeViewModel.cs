using System.Collections.Generic;
using Project3.Models;

namespace Project3.ViewModels
{
    public class DegreeViewModel
    {
        public Models.Footer FooterInfo { get; set; }
        public List<Graduate> Graduates { get; set; }
        public List<UnderGradMajors> UnderGrads { get; set; }
        public string Title { get; set; }
    }
}
