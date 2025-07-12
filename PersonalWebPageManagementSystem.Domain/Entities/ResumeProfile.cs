namespace PersonalWebPageManagementSystem.Domain.Entities
{
    public class ResumeProfile
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
        // Foreign key
        public Guid ResumeId { get; set; }
        public Resume Resume { get; set; }

        public ResumeProfile()
        {
            Id = Guid.NewGuid();
        }
    }
}
