using ProtechSolution.Commum.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtechSolution.Domain.Entities
{
    public class ProfessionalExperience
    {
        protected ProfessionalExperience() { }

        public ProfessionalExperience(string name, string dateOfBirth) 
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Formations = new List<Formation>();
            TotalExperience = 0;
            Experiences = new List<Experience>();
            CompanyExperiences = new List<CompanyExperience>();
        }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public IList<Formation> Formations { get; set; }
        public int TotalExperience { get; set; }
        public IList<Experience> Experiences { get; set; }
        public IList<CompanyExperience> CompanyExperiences { get; set; }

        
        public void Validate()
        {
            AssertionConcern.AssertArgumentNotEmpty(Name, "O nome precisa ser preenchido.");
            AssertionConcern.AssertArgumentNotEmpty(DateOfBirth, "A data de nascimento precisa ser preenchido.");
        }
    }
}
