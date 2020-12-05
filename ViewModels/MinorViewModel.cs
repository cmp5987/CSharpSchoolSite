using System.Collections.Generic;
using Project3.Models;

namespace Project3.ViewModels
{
    public class MinorViewModel
    {
        public Models.Footer FooterInfo { get; set; }
        public List<Minors> Minors { get; set; }
        public string Title { get; set; }
    }
}
