using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class PortfolioModel
    {
        public PersonalInfo Personal { get; set; } = new();
        public ProfessionalSummary Summary { get; set; } = new();
        public List<SkillCategory> TechnicalSkills { get; set; } = new();
        public List<Project> Projects { get; set; } = new();
        public List<Education> Educations { get; set; } = new();
        public List<Certification> Certifications { get; set; } = new();
        public List<Achievement> Achievements { get; set; } = new();
        public AdditionalInfo AdditionalInfo { get; set; } = new();
        public ContactForm Contact { get; set; } = new();
    }

    public class PersonalInfo
    {
        public string FullName { get; set; } = "MULONGONI WASHU";
        public string Title { get; set; } = "Software Developer";
        public string Phone1 { get; set; } = "060 301 9756";
        public string Phone2 { get; set; } = "062 001 6506";
        public string Email { get; set; } = "mulongoniwashu3@gmail.com";
        public string Address { get; set; } = "923 Makhavhu st, Tshiawelo, Soweto, Johannesburg";
        public string Nationality { get; set; } = "South African";
        public string GitHub { get; set; } = "https://github.com/Mulongoni123";
        public string LinkedIn { get; set; } = "https://linkedin.com/in/washu-mulongoni-1a8b4a261";
        public string Languages { get; set; } = "Tshivenda, English";
        public string ProfileImage { get; set; } = "/images/profile.jpg";
    }

    public class ProfessionalSummary
    {
        public string Title { get; set; } = "Final-year Software Development Student";
        public string Description { get; set; } = "Passionate about creating scalable solutions and eager to contribute to a professional development team.";
        public string DetailedDescription { get; set; } = "Final-year Software Development student with strong skills in ASP.NET Core, Java, SQL, PHP, and Firebase. Experienced in building full-stack web, mobile, and desktop applications.";
    }

    public class SkillCategory
    {
        public string Name { get; set; } = "";
        public string Icon { get; set; } = "";
        public List<Skill> Skills { get; set; } = new();
    }

    public class Skill
    {
        public string Name { get; set; } = "";
        public int Proficiency { get; set; }
        public string Color { get; set; } = "#3498db";
    }

    public class Project
    {
        public string Title { get; set; } = "";
        public string Role { get; set; } = "";
        public string Description { get; set; } = "";
        public string DetailedDescription { get; set; } = "";
        public List<string> Technologies { get; set; } = new();
        public string ImageUrl { get; set; } = "";
        public string LiveUrl { get; set; } = "";
        public string GitHubUrl { get; set; } = "";
        public string Category { get; set; } = "Web";
        public DateTime CompletionDate { get; set; }
    }

    public class Education
    {
        public string Degree { get; set; } = "";
        public string Institution { get; set; } = "";
        public string Period { get; set; } = "";
        public string Details { get; set; } = "";
        public string Icon { get; set; } = "fas fa-graduation-cap";
    }

    public class Certification
    {
        public string Title { get; set; } = "";
        public string Issuer { get; set; } = "";
        public string Date { get; set; } = "";
        public string BadgeUrl { get; set; } = "";
    }

    public class Achievement
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Icon { get; set; } = "fas fa-trophy";
        public string Date { get; set; } = "";
    }

    public class AdditionalInfo
    {
        public string Availability { get; set; } = "Immediately";
        public string WorkAuthorization { get; set; } = "South African Citizen";
        public string WillingToRelocate { get; set; } = "Yes";
        public string Hobbies { get; set; } = "Coding, learning new technologies, building apps";
    }

    public class ContactForm
    {
        [Required]
        public string Name { get; set; } = "";

        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";

        [Required]
        public string Subject { get; set; } = "";

        [Required]
        public string Message { get; set; } = "";
    }
}