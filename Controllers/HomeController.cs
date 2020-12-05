using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project3.Models;
using Project3.ViewModels;
using Project3.Services;

namespace Project3.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetFaculty _facultyRepository;

        public About AboutInfo { get; private set; }
        public string Title { get; private set; }

        public HomeController (IGetFaculty facultyRepository)
        {
            _facultyRepository = facultyRepository; 
        }

        public async Task<IActionResult> Index()
        {
            var singleFooter = new GetFooter();
            var footer = await singleFooter.GetSimpleFooter();

            var singleAbout = new GetAbout();
            var about = await singleAbout.GetSimpleAbout();
            var homeViewModel = new IndexViewModel()
            {
                FooterInfo = footer,
                AboutInfo = about,
                Title = "Rochester Institute of Technology"
            };
            return View(homeViewModel);
        }

        public async Task<IActionResult> Degrees(){
            var singleFooter = new GetFooter();
            var footer = await singleFooter.GetSimpleFooter();

            var getUnder = new GetUndergraduate();
            var under = await getUnder.GetUnderGradDegrees();
            var getGrad = new GetGraduate();
            var grad = await getGrad.GetAllGraduate();
            var degreeViewModel = new DegreeViewModel()
            {
                FooterInfo = footer,
                UnderGrads = under,
                Graduates = grad,
                Title = "Degree Programs"
            };

            return View(degreeViewModel);
        }
        public async Task<IActionResult> Faculty()
        {
            var singleFooter = new GetFooter();
            var footer = await singleFooter.GetSimpleFooter();

            var allFaculty = await _facultyRepository.GetAllFaculty();
            var sortedFaculty = allFaculty.OrderBy(f => f.username);
            var getResearch = new GetResearchByFaculty();
            var research = await getResearch.GetAllResearchByFaculty();
            var facultyViewModel = new FacultyViewModel()
            {
                FooterInfo = footer,
                ResearchByFaculty = research,
                Faculty = allFaculty.ToList(),
                Title = "Our Staff"
            };
            return View(facultyViewModel);
        }
        public async Task<IActionResult> Minors()
        {
            var singleFooter = new GetFooter();
            var footer = await singleFooter.GetSimpleFooter();

            var getMinor = new GetMinor();
            var minor = await getMinor.GetAllMinor();
            var minorViewModel = new MinorViewModel()
            {
                FooterInfo = footer,
                Minors = minor,
                Title = "Undergraduate Minors"
            };
            return View(minorViewModel);
        }
        public async Task<IActionResult> Employment()
        {
            var singleFooter = new GetFooter();
            var footer = await singleFooter.GetSimpleFooter();

            var getEmployment = new GetEmployment();
            var employment = await getEmployment.GetAllEmployment();
            var employmentViewModel = new EmploymentViewModel()
            {
                FooterInfo = footer,
                Introduction = employment.introduction,
                DegreeStatistics = employment.degreeStatistics,
                Employers = employment.employers,
                Careers = employment.careers,
                CoopTable = employment.coopTable,
                EmploymentTable = employment.employmentTable,
                Title = "Employment Information"
            };
            return View(employmentViewModel);
        }

    }
}
