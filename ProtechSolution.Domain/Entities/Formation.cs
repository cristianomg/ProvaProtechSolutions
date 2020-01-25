using ProtechSolution.Commum.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtechSolution.Domain.Entities
{
    public class Formation
    {
        public string Course { get; set; }
        public string Status { get; set; }
        public string ConclusionDate { get; set; }

        public void Validate()
        {
            AssertionConcern.AssertArgumentNotEmpty(Course, "O curso precisa ser preenchido.");
            AssertionConcern.AssertArgumentNotEmpty(Status, "O status precisa ser preenchido.");
            AssertionConcern.AssertArgumentNotEmpty(ConclusionDate, "A data de conclusão da experiencia precisa ser preenchida.");
        }
    }
}
