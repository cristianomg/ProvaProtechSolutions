using ProtechSolution.Commum.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtechSolution.Domain.Entities
{
    public class CompanyExperience
    {
        public string Company { get; set; }
        public string Position { get; set; }
        public string InitialDate { get; set; }
        public string FinalDate { get; set; }
        public string DetailExperience { get; set; }

        public void Validate()
        {
            AssertionConcern.AssertArgumentNotEmpty(Company, "O nome da empresa precisa ser preenchido.");
            AssertionConcern.AssertArgumentNotEmpty(Position, "O cargo precisa ser preenchido.");
            AssertionConcern.AssertArgumentNotEmpty(InitialDate, "A data inicial precisa ser preenchida.");
            AssertionConcern.AssertArgumentNotEmpty(FinalDate, "A data final precisa ser preenchida.");
            AssertionConcern.AssertArgumentNotEmpty(DetailExperience, "A descrição da experiencia precisa ser preenchida.");
        }
    }
}
