namespace PersonalWebPageManagementSystem.Domain.Entities
{
    public class ResumeSkill
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public short Level { get; set; } // 1-5 or 1-10 scale
        
        // Foreign key
        public Guid ResumeId { get; set; }
        public Resume Resume { get; set; }

        public ResumeSkill()
        {
            Id = Guid.NewGuid();
        }
    }
}
