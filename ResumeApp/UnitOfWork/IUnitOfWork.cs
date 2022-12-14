using ResumeApp.Data.Entities;
using ResumeApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApp.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IGenericRepository<Home, int> HomeRepository { get; set; }
        public IGenericRepository<About, int> AboutRepository { get; set; }
        public IGenericRepository<Portfolio, int> PortfolioRepository { get; set; }
        public IGenericRepository<Education, int> EducationRepository { get; set; }
        public IGenericRepository<Experience, int> ExperienceRepository { get; set; }
        public IGenericRepository<Language, int> LanguageRepository { get; set; }
        public IGenericRepository<Programming, int> ProgrammingRepository { get; set; }
        public IGenericRepository<Services, int> ServicesRepository { get; set; }
        public Task Commit();
    }
}
