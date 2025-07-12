namespace PersonalWebPageManagementSystem.Application.DTOs
{
    public class ResumeExperienceDto
    {
        public Guid Id { get; set; }
        public string JobTitle { get; set; }
        public string Employer { get; set; }
        public string City { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
