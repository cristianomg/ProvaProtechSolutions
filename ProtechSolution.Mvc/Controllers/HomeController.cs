using ProtechSolution.Domain.Contracts;
using ProtechSolution.Domain.Entities;
using ProtechSolution.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProtechSolution.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private IService service;
        public HomeController(IService service)
        {
            this.service = service;
        }
        public ActionResult Index()
        {
            try
            {
                ProfessionalExperience professionalExperience = service.Get();
                ProfessionalExperienceModel model = new ProfessionalExperienceModel()
                {
                    Name = professionalExperience.Name,
                    DateOfBirth = professionalExperience.DateOfBirth,
                    TotalExperience = professionalExperience.TotalExperience,
                    Formations = professionalExperience.Formations,
                    CompanyExperiences = professionalExperience.CompanyExperiences,
                    Experiences = professionalExperience.Experiences
                };
                return View(model);
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult InsertExperience()
        {
            ExperienceModel model = new ExperienceModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult InsertExperience(ExperienceModel model)
        {
            try
            {
                service.Insert(model.Technology, model.TimeExperience, model.DetailExperience);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error: " + ex.Message;
                return View(model);
            }


        }
        [HttpGet]
        public ActionResult InsertCompanyExperience()
        {
            CompanyExperienceModel model = new CompanyExperienceModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult InsertCompanyExperience(CompanyExperienceModel model)
        {
            try
            {
                service.Insert(model.Company, model.Position, model.InitialDate, model.FinalDate, model.DetailExperience);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error: " + ex.Message;
                return View(model);
            }


        }
        [HttpGet]
        public ActionResult InsertFormation()
        {
            FormationModel model = new FormationModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult InsertFormation(FormationModel model)
        {
            try
            {
                service.Insert(model.Course, model.Status, model.ConclusionDate);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.Message = "Error: " + ex.Message;
                return View(model);
            }

        }
    }
}