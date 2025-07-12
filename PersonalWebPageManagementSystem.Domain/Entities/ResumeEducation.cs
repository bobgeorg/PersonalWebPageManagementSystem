namespace PersonalWebPageManagementSystem.Domain.Entities
{
    public class ResumeEducation
    {
        public Guid Id { get; set; }
        public string Institution { get; set; }
        public string Degree { get; set; }
        public string FieldOfStudy { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        
        // Foreign key
        public Guid ResumeId { get; set; }
        public Resume Resume { get; set; }

        public ResumeEducation()
        {
            Id = Guid.NewGuid();
        }
    }
}
