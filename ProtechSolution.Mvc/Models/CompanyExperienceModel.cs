using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProtechSolution.Mvc.Models
{
    public class CompanyExperienceModel
    {
        public string Company { get; set; }
        public string Position { get; set; }
        public string InitialDate { get; set; }
        public string FinalDate { get; set; }
        public string DetailExperience { get; set; }
    }
}