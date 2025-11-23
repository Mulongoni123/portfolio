using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly PortfolioModel _portfolio;

        public HomeController()
        {
            _portfolio = InitializePortfolioData();
        }

        public IActionResult Index()
        {
            return View(_portfolio);
        }

        public IActionResult About()
        {
            return View(_portfolio);
        }

        public IActionResult Projects()
        {
            return View(_portfolio);
        }

        public IActionResult Skills()
        {
            return View(_portfolio);
        }

        public IActionResult Contact()
        {
            return View(_portfolio);
        }

        [HttpPost]
        public IActionResult Contact(ContactForm model)
        {
            if (ModelState.IsValid)
            {
                // Here you would typically send the email
                TempData["SuccessMessage"] = "Thank you for your message! I'll get back to you soon.";
                return RedirectToAction("Contact");
            }
            return View(_portfolio);
        }

        private PortfolioModel InitializePortfolioData()
        {
            return new PortfolioModel
            {
                Personal = new PersonalInfo
                {
                    FullName = "MULONGONI WASHU",
                    Title = "Full Stack Developer",
                    Phone1 = "060 301 9756",
                    Phone2 = "062 001 6506",
                    Email = "mulongoniwashu3@gmail.com",
                    Address = "923 Makhavhu st, Tshiawelo, Soweto, Johannesburg",
                    Nationality = "South African",
                    GitHub = "https://github.com/Mulongoni123",
                    LinkedIn = "https://linkedin.com/in/washu-mulongoni-1a8b4a261",
                    Languages = "Tshivenda, English",
                    ProfileImage = "/images/profile-placeholder.jpg"
                },
                Summary = new ProfessionalSummary
                {
                    Title = "Final-year Software Development Student",
                    Description = "Passionate about creating scalable solutions and eager to contribute to professional development teams.",
                    DetailedDescription = "Final-year Software Development student with strong skills in ASP.NET Core, Java, SQL, PHP, and Firebase. Experienced in building full-stack web, mobile, and desktop applications."
                },
                TechnicalSkills = new List<SkillCategory>
                {
                    new() {
                        Name = "Programming Languages",
                        Icon = "fas fa-code",
                        Skills = new List<Skill> {
                            new() { Name = "C#", Proficiency = 85, Color = "#178600" },
                            new() { Name = "Java", Proficiency = 80, Color = "#ED8B00" },
                            new() { Name = "PHP", Proficiency = 75, Color = "#777BB4" },
                            new() { Name = "JavaScript", Proficiency = 80, Color = "#F7DF1E" },
                            new() { Name = "SQL", Proficiency = 85, Color = "#4479A1" }
                        }
                    },
                    new() {
                        Name = "Web Technologies",
                        Icon = "fas fa-globe",
                        Skills = new List<Skill> {
                            new() { Name = "ASP.NET Core MVC", Proficiency = 85, Color = "#512BD4" },
                            new() { Name = "Bootstrap 5", Proficiency = 80, Color = "#7952B3" },
                            new() { Name = "HTML5", Proficiency = 90, Color = "#E34F26" },
                            new() { Name = "CSS3", Proficiency = 85, Color = "#1572B6" },
                            new() { Name = "REST APIs", Proficiency = 80, Color = "#FF6C37" }
                        }
                    },
                    new() {
                        Name = "Mobile & Desktop",
                        Icon = "fas fa-mobile-alt",
                        Skills = new List<Skill> {
                            new() { Name = "Android (Java)", Proficiency = 75, Color = "#3DDC84" },
                            new() { Name = "Java Swing", Proficiency = 70, Color = "#ED8B00" }
                        }
                    },
                    new() {
                        Name = "Databases",
                        Icon = "fas fa-database",
                        Skills = new List<Skill> {
                            new() { Name = "Firestore", Proficiency = 80, Color = "#FFCA28" },
                            new() { Name = "MySQL", Proficiency = 85, Color = "#4479A1" },
                            new() { Name = "Oracle", Proficiency = 75, Color = "#F80000" }
                        }
                    },
                    new() {
                        Name = "Tools & Cloud",
                        Icon = "fas fa-tools",
                        Skills = new List<Skill> {
                            new() { Name = "Git/GitHub", Proficiency = 85, Color = "#181717" },
                            new() { Name = "Visual Studio", Proficiency = 90, Color = "#5C2D91" },
                            new() { Name = "Android Studio", Proficiency = 80, Color = "#3DDC84" },
                            new() { Name = "VS Code", Proficiency = 85, Color = "#007ACC" },
                            new() { Name = "Firebase", Proficiency = 80, Color = "#FFCA28" },
                            new() { Name = "Google Cloud", Proficiency = 70, Color = "#4285F4" }
                        }
                    }
                },
                // In the InitializePortfolioData method, update the Projects list:
                Projects = new List<Project>
{
    new()
    {
        Title = "The Rock Waste Management System",
        Role = "Project Leader & Full Stack Developer",
        Description = "Cloud-based waste management platform with multi-role login and real-time features.",
        DetailedDescription = "A comprehensive full-stack web application built with ASP.NET Core that streamlines the entire waste management service lifecycle from booking to completion. Features include multi-role authentication, real-time booking system, worker dashboards, payment processing, and Firestore database integration.",
        Technologies = new List<string> { "ASP.NET Core", "C#", "Firestore", "Bootstrap 5", "JavaScript", "Google Cloud Platform" },
        ImageUrl = "/images/waste-management.jpg",
        LiveUrl = "https://therockwastemanagement-pro-612370591242.europe-west1.run.app",
        GitHubUrl = "https://github.com/Mulongoni123/the-rock-waste-management",
        Category = "Web Application",
        CompletionDate = new DateTime(2025, 11, 11)
    },
    new()
    {
        Title = "DustbinPro Mobile App",
        Role = "Mobile Developer",
        Description = "Android application for waste management and cleaning service requests.",
        DetailedDescription = "A mobile application designed to simplify and digitalize waste management and cleaning service requests. The app allows customers to book services, view booking status, and make payments, while enabling admins and workers to manage bookings efficiently through Firebase integration.",
        Technologies = new List<string> { "Java", "Android SDK", "Firebase", "Firestore", "Google Maps API" },
        ImageUrl = "/images/dustbinpro.jpg",
        LiveUrl = "#",
        GitHubUrl = "https://github.com/Mulongoni123/DustbinPro",
        Category = "Mobile Application",
        CompletionDate = new DateTime(2025, 11, 10)
    },
    new()
    {
        Title = "Disaster Alleviation Foundation",
        Role = "Full Stack Developer",
        Description = "Web application for disaster relief operations and donation management.",
        DetailedDescription = "A comprehensive web application designed to streamline disaster relief operations, coordinate donations, and manage aid distribution efficiently. Built with modern .NET technologies, this platform connects donors, volunteers, and disaster victims in a centralized ecosystem.",
        Technologies = new List<string> { "ASP.NET Core 8.0", "C#", "Entity Framework", "SQL Server", "Bootstrap", "JavaScript" },
        ImageUrl = "/images/disaster-alleviation.jpg",
        LiveUrl = "#",
        GitHubUrl = "https://github.com/Mulongoni123/DisasterAlleviationFoundation",
        Category = "Web Application",
        CompletionDate = new DateTime(2025, 10, 3)
    }
},
                Educations = new List<Education>
                {
                    new() {
                        Degree = "Diploma in Software Development",
                        Institution = "Rosebank College",
                        Period = "2023 – 2025 (Final Year)",
                        Details = "Key Modules: OOP (Java/C#), Web Development, Database Systems, Mobile Development, Data Structures & Algorithms",
                        Icon = "fas fa-graduation-cap"
                    },
                    new() {
                        Degree = "National Senior Certificate",
                        Institution = "Dzata Secondary School",
                        Period = "2015-2022",
                        Details = "Completed secondary education with focus on Mathematical literacy and History",
                        Icon = "fas fa-school"
                    }
                },
                Certifications = new List<Certification>
                {
                    new() {
                        Title = "FULLSTACK DEVELOPER FNB ACADEMY",
                        Issuer = "IT VARSITY",
                        Date = "2025",
                        BadgeUrl = "/images/fnb-certification.jpg"
                    },
                    new() {
                        Title = "SOFTWARE ENGINEER INTERN",
                        Issuer = "HACKERRANK",
                        Date = "2025",
                        BadgeUrl = "/images/hackerrank-certification.jpg"
                    }
                },
                Achievements = new List<Achievement>
                {
                    new() {
                        Title = "High-Quality Academic Projects",
                        Description = "Delivered multiple high-quality academic software projects with excellent feedback",
                        Icon = "fas fa-medal",
                        Date = "2023-2024"
                    },
                    new() {
                        Title = "Coding Workshop Leader",
                        Description = "Active participant and leader in coding workshops and tech sessions",
                        Icon = "fas fa-users",
                        Date = "2024"
                    },
                    new() {
                        Title = "Problem Solving Excellence",
                        Description = "Strong debugging and problem-solving skills demonstrated in various projects",
                        Icon = "fas fa-bug",
                        Date = "2023-2024"
                    }
                },
                AdditionalInfo = new AdditionalInfo
                {
                    Availability = "Immediately",
                    WorkAuthorization = "South African Citizen",
                    WillingToRelocate = "Yes",
                    Hobbies = "Coding, learning new technologies, building apps, open source contribution"
                }
            };
        }
    }
}