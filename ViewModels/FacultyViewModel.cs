using System.Collections.Generic;
using Project3.Models;

namespace Project3.ViewModels
{
    public class FacultyViewModel
    {
        public Models.Footer FooterInfo { get; set; }
        public List<ByFaculty> ResearchByFaculty { get; set; }
        public List<Faculty> Faculty { get; set; }
        public string Title { get; set; }
    }
}
