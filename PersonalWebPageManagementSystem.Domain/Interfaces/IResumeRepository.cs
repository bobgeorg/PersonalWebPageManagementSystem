using PersonalWebPageManagementSystem.Domain.Entities;

namespace PersonalWebPageManagementSystem.Domain.Interfaces
{
    public interface IResumeRepository
    {
        Task<Resume> GetByIdAsync(Guid id);
        Task<IEnumerable<Resume>> GetAllAsync();
        Task<Resume> CreateAsync(Resume resume);
        Task<Resume> UpdateAsync(Resume resume);
        Task DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
    }
}
