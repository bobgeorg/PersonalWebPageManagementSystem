using PersonalWebPageManagementSystem.Application.DTOs;

namespace PersonalWebPageManagementSystem.Application.Services
{
    public interface IResumeService
    {
        Task<ResumeDto> GetResumeByIdAsync(Guid id);
        Task<IEnumerable<ResumeDto>> GetAllResumesAsync();
        Task<ResumeDto> CreateResumeAsync(ResumeDto resumeDto);
        Task<ResumeDto> UpdateResumeAsync(ResumeDto resumeDto);
        Task DeleteResumeAsync(Guid id);
        Task<bool> ResumeExistsAsync(Guid id);
    }
}
