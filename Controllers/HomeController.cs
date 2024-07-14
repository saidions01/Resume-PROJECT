using Microsoft.AspNetCore.Mvc;
using ResumeProject.Models;
using System.Diagnostics;

namespace ResumeProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult GetAbout()
        {
            List<About> alistOfAbout = new List<About>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfAbout = aGateway.GetAbout();
            ViewBag.ListAbout = alistOfAbout;

            return View();
        }

        public IActionResult GetAbout(int id)
        {

            List<About> alistOfAbout = new List<About>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfAbout = aGateway.GetAbout(id);
            ViewBag.ListAbout = alistOfAbout;

            return View();
        }

        public IActionResult InsertAboutForm()
        {
            return View();
        }
        public IActionResult InsertAbout( string content, string time)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            DBGateway aGateway = new DBGateway(configuration);

            aGateway.InsertAbout( content, time);

            return RedirectToAction("Index", "Home");
        }
        public IActionResult UpdateAboutForm(int id)
        {
            List<About> alistOfAbout = new List<About>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfAbout = aGateway.GetAbout(id);
            ViewBag.ListAbout = alistOfAbout;

            return View();
        }


        
        public IActionResult UpdateAbout(int id, string content, string time)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            DBGateway aGateway = new DBGateway(configuration);

            aGateway.UpdateAbout(id, content, time);

            return RedirectToAction("Index", "Home");
        }
        public IActionResult GetBasicInformation()
        {


            List<BasicInformation> alistOfBI = new List<BasicInformation>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfBI = aGateway.GetBasicInformation();
            ViewBag.ListOfBasicInformation = alistOfBI;
            return View();

        }



        public IActionResult GetBasicInformation(int id)
        {


            List<BasicInformation> alistOfBI = new List<BasicInformation>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfBI = aGateway.GetBasicInformation(id);
            ViewBag.ListOfBasicInformation = alistOfBI;
            return View();

        }

        public IActionResult InsertBasicInformationForm()
        {
            return View();
        }
        public IActionResult InsertBasicInformation(string name, string email, string phoneNumber)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            DBGateway aGateway = new DBGateway(configuration);

            aGateway.InsertBasicInformation( name,  email,  phoneNumber);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult UpdateBasicInformationForm(int id)
        {
            List<BasicInformation> alistOfBI = new List<BasicInformation>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfBI = aGateway.GetBasicInformation(id);
            ViewBag.ListOfBasicInformation = alistOfBI;
            return View();
        }
        public IActionResult UpdateBasicInformation(int id,string name, string email, string phoneNumber)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            DBGateway aGateway = new DBGateway(configuration);

            aGateway.UpdateBasicInformation(id, name,  email,  phoneNumber);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult GetCertifications()
        {


            List<Certifications> alistOfCertifications = new List<Certifications>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfCertifications = aGateway.GetCertifications();
            ViewBag.ListOfCertifications = alistOfCertifications;
            return View();

        }


        public IActionResult GetCertifications(int id)
        {


            List<Certifications> alistOfCertifications = new List<Certifications>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfCertifications = aGateway.GetCertifications(id);
            ViewBag.ListOfCertifications = alistOfCertifications;
            return View();

        }

        public IActionResult InsertCertificationsForm()
        {
            return View();
        }

        public IActionResult InsertCertifications(string certificationName, string issuingOrganization, string dateObtained)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            DBGateway aGateway = new DBGateway(configuration);

            aGateway.InsertCertification(   certificationName,  issuingOrganization,  dateObtained);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult UpdateCertificationsForm(int id)
        {

            List<Certifications> alistOfCertifications = new List<Certifications>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfCertifications = aGateway.GetCertifications(id);
            ViewBag.ListOfCertifications = alistOfCertifications;
            return View();
        }

        public IActionResult UpdateCertifications(int id, string certificationName, string issuingOrganization, string dateObtained)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            DBGateway aGateway = new DBGateway(configuration);

            aGateway.UpdateCertifications(id, certificationName, issuingOrganization, dateObtained);

            return RedirectToAction("Index", "Home");
        }


        public IActionResult GetEducation()
        {

            List<Education> alistOfEducation = new List<Education>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfEducation = aGateway.GetEducation();
            ViewBag.ListOfEducation = alistOfEducation;
            return View();

        }

        public IActionResult GetEducation(int id)
        {

            List<Education> alistOfEducation = new List<Education>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfEducation = aGateway.GetEducation(id);
            ViewBag.ListOfEducation = alistOfEducation;
            return View();

        }
        public IActionResult InsertEducationForm()
        {
            return View();
        }

        public IActionResult InsertEducation( string degree, string school, int graduationYear, float gpa)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            DBGateway aGateway = new DBGateway(configuration);

            aGateway.InsertEducation(  degree,  school,  graduationYear,  gpa);

            return RedirectToAction("Index", "Home");

        }

        public IActionResult UpdateEducationForm(int id)
        {
            List<Education> alistOfEducation = new List<Education>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfEducation = aGateway.GetEducation(id);
            ViewBag.ListOfEducation = alistOfEducation;
            return View();
        }

        public IActionResult UpdateEducation(int id, string degree, string school, int graduationYear, float gpa)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            DBGateway aGateway = new DBGateway(configuration);

            aGateway.UpdateEducation(id, degree, school,  graduationYear, gpa);

            return RedirectToAction("Index", "Home");
        }


        public IActionResult GetLanguages()
        {


            List<Languages> alistOfLanguages = new List<Languages>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfLanguages = aGateway.GetLanguages();
            ViewBag.ListOfLanguages = alistOfLanguages;
            return View();

        }
        public IActionResult GetLanguages(int id)
        {


            List<Languages> alistOfLanguages = new List<Languages>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfLanguages = aGateway.GetLanguages(id);
            ViewBag.ListOfLanguages = alistOfLanguages;
            return View();

        }

        public IActionResult InsertLanguagesForm()
        {
            return View();
        }

        public IActionResult InsertLanguages( string languageName, string proficiencyLevel)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            DBGateway aGateway = new DBGateway(configuration);

            aGateway.InsertLanguages( languageName,  proficiencyLevel);

            return RedirectToAction("Index", "Home");

        }



        public IActionResult UpdateLanguagesForm(int id)
        {
            List<Languages> alistOfLanguages = new List<Languages>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfLanguages = aGateway.GetLanguages(id);
            ViewBag.ListOfLanguages = alistOfLanguages;

            return View();
        }

        public IActionResult UpdateLanguages(int id, string languageName, string proficiencyLevel)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            DBGateway aGateway = new DBGateway(configuration);

            aGateway.UpdateLanguages(id, languageName, proficiencyLevel);

            return RedirectToAction("Index", "Home");
        }



        public IActionResult GetProjects()
        {


            List<Projects> alistOfProjects = new List<Projects>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfProjects = aGateway.GetProjects();
            ViewBag.ListOfProjects = alistOfProjects;
            return View();

        }



        public IActionResult GetProjects(int id)
        {


            List<Projects> alistOfProjects = new List<Projects>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfProjects = aGateway.GetProjects(id);
            ViewBag.ListOfProjects = alistOfProjects;
            return View();

        }

        public IActionResult InsertProjectsForm()
        {
            return View();
        }

        public IActionResult InsertProjects(string projectName, string description , string technologiesUsed , int duration)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            DBGateway aGateway = new DBGateway(configuration);

            aGateway.InsertProjects(  projectName,  description,  technologiesUsed,  duration);

            return RedirectToAction("Index", "Home");

        }

        public IActionResult UpdateProjectsForm(int id)
        {

            List<Projects> alistOfProjects = new List<Projects>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfProjects = aGateway.GetProjects(id);
            ViewBag.ListOfProjects = alistOfProjects;
            return View();
        }

        public IActionResult UpdateProjects(int id, string projectName, string description, string technologiesUsed, int duration)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            DBGateway aGateway = new DBGateway(configuration);

            aGateway.UpdateProjects(id, projectName, description, technologiesUsed, duration);
            return RedirectToAction("Index", "Home");
        }





        public IActionResult GetSkills()
        {


            List<Skill> alistOfSkills = new List<Skill>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfSkills = aGateway.GetSkills();
            ViewBag.ListOfSkills = alistOfSkills;
            return View();

        }

        public IActionResult GetSkills(int id)
        {


            List<Skill> alistOfSkills = new List<Skill>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfSkills = aGateway.GetSkills(id);
            ViewBag.ListOfSkills = alistOfSkills;
            return View();

        }

        public IActionResult InsertSkillsForm()
        {
            return View();
        }

        public IActionResult InsertSkills (string skillName, string proficiencyLevel)
        {
             IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        DBGateway aGateway = new DBGateway(configuration);

        aGateway.InsertSkills( skillName,  proficiencyLevel);

            return RedirectToAction("Index", "Home");
    }

        public IActionResult UpdateSkillsForm(int id)
        {

            List<Skill> alistOfSkills = new List<Skill>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfSkills = aGateway.GetSkills(id);
            ViewBag.ListOfSkills = alistOfSkills;
            return View();
        }
        public IActionResult UpdateSkills(int id, string skillName, string proficiencyLevel)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            DBGateway aGateway = new DBGateway(configuration);

            aGateway.UpdateSkills(id, skillName, proficiencyLevel);

            return RedirectToAction("Index", "Home");
        }
    

   

      



        public IActionResult GetExperience()
        {


            List<Experience> alistOfExperience = new List<Experience>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfExperience = aGateway.GetExperience();
            ViewBag.ListOfExperience = alistOfExperience;
            return View();

        }

        public IActionResult GetExperience(int id)
        {


            List<Experience> alistOfExperience = new List<Experience>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfExperience = aGateway.GetExperience(id);
            ViewBag.ListOfExperience = alistOfExperience;
            return View();

        }

        public IActionResult InsertExperienceForm()
        {
            return View();
        }

        public IActionResult InsertExperience( string jobTitle, string company, string startDate, string endDate, string responsibilities)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            DBGateway aGateway = new DBGateway(configuration);

            aGateway.InsertExperience( jobTitle,  company,  startDate,  endDate, responsibilities);

            return RedirectToAction("Index", "Home");

        }

        public IActionResult UpdateExperienceForm(int id)
        {

            List<Experience> alistOfExperience = new List<Experience>();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DBGateway aGateway = new DBGateway(configuration);
            alistOfExperience = aGateway.GetExperience(id);
            ViewBag.ListOfExperience = alistOfExperience;
            return View();
        }

        public IActionResult UpdateExperience(int id, string jobTitle, string company, string startDate, string endDate, string responsibilities)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            DBGateway aGateway = new DBGateway(configuration);

            aGateway.UpdateExperience(id, jobTitle, company, startDate, endDate, responsibilities);

            return RedirectToAction("Index", "Home");
        }


        public IActionResult Resume()
        {

            List<Education> aListOfEducation = new List<Education>();
            List<Experience> aListOfExperiences = new List<Experience>();
            List<Languages> aListOfLanguages = new List<Languages>();
            List<BasicInformation> aListOfBasicInformation = new List<BasicInformation>();
            List<Projects> aListOfProjects = new List<Projects>();
            List<Skill> aListOfSkills = new List<Skill>();
            List<About> aListOfAbouts = new List<About>();
            List<Certifications> aListOfCertifications = new List<Certifications>();


            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            DBGateway aGateway = new DBGateway(configuration);
            aListOfEducation= aGateway.GetEducation();
            aListOfExperiences = aGateway.GetExperience();
            aListOfLanguages= aGateway.GetLanguages();
            aListOfBasicInformation = aGateway.GetBasicInformation();
            aListOfProjects= aGateway.GetProjects();
            aListOfSkills = aGateway.GetSkills();
            aListOfAbouts = aGateway.GetAbout();
            aListOfCertifications = aGateway.GetCertifications();


            ViewBag.Education = aListOfEducation;
            ViewBag.Experience = aListOfExperiences;
            ViewBag.Languages = aListOfLanguages;
            ViewBag.BasicInformation = aListOfBasicInformation;
            ViewBag.Projects = aListOfProjects;
            ViewBag.Skills = aListOfSkills;
            ViewBag.Abouts = aListOfAbouts;
            ViewBag.Certifications = aListOfCertifications;
            


            return View();



        }
    }
}