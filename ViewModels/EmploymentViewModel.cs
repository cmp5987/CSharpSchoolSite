using System.Collections.Generic;
using Project3.Models;

namespace Project3.ViewModels
{
    public class EmploymentViewModel
    {
        public Models.Footer FooterInfo { get; set; }
        public Introduction Introduction { get; set; }
        public DegreeStatistics DegreeStatistics { get; set; }
        public Employers Employers { get; set; }
        public Careers Careers { get; set; }
        public CoopTable CoopTable { get; set; }
        public EmploymentTable EmploymentTable { get; set; }

        public string Title { get; set; }

    }
}
