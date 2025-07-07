namespace PersonalWebPageManagementSystem.ViewModels
{
    public class ResumeEducationVm :ResumeBaseVm
    {
        public string Institution { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
