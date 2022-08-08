using ResumeApp.Data;
using ResumeApp.Data.Entities;
using ResumeApp.Repository;
using ResumeApp.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApp.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IGenericRepository<Home, int> HomeRepository { get; set; }
        public IGenericRepository<About, int> AboutRepository { get; set; }
        public IGenericRepository<Portfolio, int> PortfolioRepository { get; set; }
        public IGenericRepository<Education, int> EducationRepository { get; set; }
        public IGenericRepository<Experience, int> ExperienceRepository { get; set; }
        public IGenericRepository<Language, int> LanguageRepository { get; set; }
        public IGenericRepository<Programming, int> ProgrammingRepository { get; set; }
        public IGenericRepository<Services, int> ServicesRepository { get; set; }


        private readonly MyContext _mycontext;
        public UnitOfWork(MyContext mycontext)
        {
            _mycontext = mycontext;
            HomeRepository = new EfRepository<Home, int>(mycontext);
            AboutRepository = new EfRepository<About, int>(mycontext);
            PortfolioRepository = new EfRepository<Portfolio, int>(mycontext);
            EducationRepository = new EfRepository<Education, int>(mycontext);
            ExperienceRepository = new EfRepository<Experience, int>(mycontext);
            LanguageRepository = new EfRepository<Language, int>(mycontext);
            ProgrammingRepository = new EfRepository<Programming, int>(mycontext);
            ServicesRepository = new EfRepository<Services, int>(mycontext);
        }

        public async Task Commit()
        {
            await _mycontext.SaveChangesAsync();
        }
    }
}
