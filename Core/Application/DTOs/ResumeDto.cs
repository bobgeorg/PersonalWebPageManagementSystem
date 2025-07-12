namespace PersonalWebPageManagementSystem.Core.Application.DTOs
{
    public class ResumeDto
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
        
        public ResumeProfileDto Profile { get; set; }
        public List<ResumeExperienceDto> EmploymentHistory { get; set; } = new List<ResumeExperienceDto>();
        public List<ResumeEducationDto> Education { get; set; } = new List<ResumeEducationDto>();
        public List<ResumeSkillDto> Skills { get; set; } = new List<ResumeSkillDto>();
    }
}
