using ProtechSolution.Domain.Contracts;
using ProtechSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtechSolution.Business.Services
{
    public class ExperienceService : IService
    {
        private IRepository _repo;
        public ExperienceService(IRepository experienceRepository)
        {
            _repo = experienceRepository;
        }
        public ProfessionalExperience Get()
        {
            return _repo.Get();
        }
        public void Insert(string technology, int timeExperience, string detailExperience)
        {
            Experience experience = new Experience()
            {
                Technology = technology,
                TimeExperience = timeExperience,
                DetailExperience = detailExperience
            };
            experience.Validate();
            _repo.Insert(experience);
        }
        public void Insert(string company, string position, string initialDate, string finalDate, string detailExperience)
        {
            CompanyExperience companyExperience = new CompanyExperience()
            {
                Company = company,
                Position = position,
                InitialDate = initialDate,
                FinalDate = finalDate,
                DetailExperience = detailExperience
            };
            companyExperience.Validate();
            _repo.Insert(companyExperience);
        }

        public void Insert(string course, string status, string conclusionDate)
        {
            Formation formation = new Formation()
            {
                Course = course,
                Status = status,
                ConclusionDate = conclusionDate
            };
            formation.Validate();
            _repo.Insert(formation);
        }
    }
}
