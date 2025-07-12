namespace PersonalWebPageManagementSystem.Core.Domain.Entities
{
    public class Resume
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        
        // Navigation properties
        public ResumeProfile Profile { get; set; }
        public List<ResumeExperience> EmploymentHistory { get; set; } = new List<ResumeExperience>();
        public List<ResumeEducation> Education { get; set; } = new List<ResumeEducation>();
        public List<ResumeSkill> Skills { get; set; } = new List<ResumeSkill>();

        public Resume()
        {
            Id = Guid.NewGuid();
        }
    }
}
