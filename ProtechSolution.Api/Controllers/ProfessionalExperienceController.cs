using ProtechSolution.Domain.Contracts;
using ProtechSolution.Domain.Entities;
using ProtechSolution.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProtechSolution.Api.Controllers
{
    [RoutePrefix("api")]
    public class ProfessionalExperienceController : ApiController
    {
        private IService service;

        public ProfessionalExperienceController(IService service)
        {
            this.service = service;
        }
        [Route("experience")]
        public IHttpActionResult Get()
        {
            try
            {
                ProfessionalExperience exp = service.Get();
                if (exp != null)
                    return Ok(service.Get());
                else
                    return NotFound();
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        [Route("experience")]
        [HttpPost]
        public IHttpActionResult PostExperience([FromBody]ExperienceModel model)
        {
            try 
            {
                service.Insert(model.Technology, model.TimeExperience, model.DetailExperience);
                return Created("Experiencia inserida", service.Get());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        [Route("company")]
        [HttpPost]
        public IHttpActionResult PostCompanyExperience([FromBody]CompanyExperienceModel model)
        {
            try
            {
                service.Insert(model.Company, model.Position, model.InitialDate, model.FinalDate, model.DetailExperience);
                return Created("Experiencia de empresa inserida", service.Get());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        [Route("formation")]
        [HttpPost]
        public IHttpActionResult PostFormation([FromBody]FormationModel model)
        {
            try
            {
                service.Insert(model.Course, model.Status, model.ConclusionDate);
                return Created("Formação inserida", service.Get());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
