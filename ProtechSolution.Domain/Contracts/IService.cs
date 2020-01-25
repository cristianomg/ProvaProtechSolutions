using ProtechSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtechSolution.Domain.Contracts
{
    public interface IService
    {
        ProfessionalExperience Get();
        void Insert(string technology, int timeExperience, string detailExperiencee);
        void Insert(string company, string position, string initialDate, string finalDate, string detailExperience);
        void Insert(string course, string status, string conclusionDate);
    }
}
