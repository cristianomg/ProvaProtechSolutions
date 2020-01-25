using ProtechSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ProtechSolution.Infrastructure.DataContext
{
    public sealed class ProtechDbContext
    {
        public ProfessionalExperience ProfessionalExperience { get; set; }

        private static ProtechDbContext _instance;
        public static ProtechDbContext Instance { get { return _instance ?? (_instance = new ProtechDbContext()); }}

        private ProtechDbContext()
        {
            ProfessionalExperience = new ProfessionalExperience("Cristiano", "24");
            ProfessionalExperience.TotalExperience = 3;
            ProfessionalExperience.Formations.Add(new Formation()
            {
                Course = "Engenharia Mecatronica",
                ConclusionDate = "2019",
                Status = "Concluido"
            });
            ProfessionalExperience.Formations.Add(new Formation()
            {
                Course = "Ciência da computação",
                ConclusionDate = "2022",
                Status = "Andamento"
            });
            ProfessionalExperience.CompanyExperiences.Add(new CompanyExperience
            {
                Company = "Atos Capital",
                InitialDate = "02/12/2019",
                FinalDate = "--/--/--",
                Position = "Desenvolvedor Júnior",
                DetailExperience = "Desenvolvimento de web crawler utiliznado c#"
            });

            ProfessionalExperience.CompanyExperiences.Add(new CompanyExperience
            {
                Company = "Atos Capital",
                InitialDate = "02/12/2019",
                FinalDate = "--/--/--",
                Position = "Desenvolvedor Júnior",
                DetailExperience = "Desenvolvimento de web crawler utiliznado c#"
            });

            ProfessionalExperience.Experiences.Add(new Experience()
            {
                Technology = "c#",
                TimeExperience = 2,
                DetailExperience = "desenvolvimento de spiders para coleta de dados em sites"
            });


        }
    }
}
