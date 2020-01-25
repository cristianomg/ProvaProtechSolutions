using ProtechSolution.Commum.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtechSolution.Domain.Entities
{
    public class Experience
    {
        public string Technology { get; set; }
        public int TimeExperience { get; set; }
        public string DetailExperience { get; set; }



        public void Validate()
        {
            AssertionConcern.AssertArgumentNotEmpty(Technology, "A tecnologia trabalhada precisa ser preenchida.");
            AssertionConcern.AssertArgumentRange(TimeExperience, 0.0, 1000.0, "O tempo de experiencia deve está entre 0 e 1000");
            AssertionConcern.AssertArgumentNotEmpty(DetailExperience, "A descrição da experiencia precisa ser preenchida.");
        }
    }
}
