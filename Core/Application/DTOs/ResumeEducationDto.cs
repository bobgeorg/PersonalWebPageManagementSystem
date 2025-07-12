namespace PersonalWebPageManagementSystem.Core.Application.DTOs
{
    public class ResumeEducationDto
    {
        public Guid Id { get; set; }
        public string Institution { get; set; }
        public string Degree { get; set; }
        public string FieldOfStudy { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
