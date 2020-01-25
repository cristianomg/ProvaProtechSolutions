using ProtechSolution.Infrastructure.DataContext;
using ProtechSolution.Domain.Contracts;
using ProtechSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtechSolution.Infrastructure.Repositories
{
    public class ExperienceRepository : IRepository
    {
        private ProtechDbContext _db;
        public ExperienceRepository()
        {
            _db = ProtechDbContext.Instance;
        }
        public ProfessionalExperience Get()
        {
            return _db.ProfessionalExperience;
        }

        public void Insert(Experience experience)
        {
            _db.ProfessionalExperience.Experiences.Add(experience);
            _db.ProfessionalExperience.TotalExperience++;
        }

        public void Insert(CompanyExperience companyExperience)
        {
            _db.ProfessionalExperience.CompanyExperiences.Add(companyExperience);
            _db.ProfessionalExperience.TotalExperience++;

        }

        public void Insert(Formation formation)
        {
            _db.ProfessionalExperience.Formations.Add(formation);
        }
    }
}
