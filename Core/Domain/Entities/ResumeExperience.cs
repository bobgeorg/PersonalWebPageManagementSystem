namespace PersonalWebPageManagementSystem.Core.Domain.Entities
{
    public class ResumeExperience
    {
        public Guid Id { get; set; }
        public string JobTitle { get; set; }
        public string Employer { get; set; }
        public string City { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        
        // Foreign key
        public Guid ResumeId { get; set; }
        public Resume Resume { get; set; }

        public ResumeExperience()
        {
            Id = Guid.NewGuid();
        }
    }
}
