using ProtechSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtechSolution.Domain.Contracts
{
    public interface IRepository
    {
        ProfessionalExperience Get();
        void Insert(Experience experience);
        void Insert(CompanyExperience companyExperience);
        void Insert(Formation formation);
    }
}
