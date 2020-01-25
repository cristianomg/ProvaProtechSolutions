using ProtechSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProtechSolution.Mvc.Models
{
    public class ProfessionalExperienceModel
    {
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public IList<Formation> Formations { get; set; }
        public int TotalExperience { get; set; }
        public IList<Experience> Experiences { get; set; }
        public IList<CompanyExperience> CompanyExperiences { get; set; }
    }
}