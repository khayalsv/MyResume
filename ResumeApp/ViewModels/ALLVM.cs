using ResumeApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApp.ViewModels
{
    public class ALLVM
    {
        public List<About> Abouts { get; set; }
        public List<Services> Services { get; set; }
        public List<Programming> Programmings { get; set; }
        public List<Education> Educations { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Portfolio> Portfolios { get; set; }
        public List<Home> Homes { get; set; }
        public List<Language> Languages { get; set; }
    }
}
