using Microsoft.EntityFrameworkCore;
using PersonalWebPageManagementSystem.Domain.Entities;
using PersonalWebPageManagementSystem.Domain.Interfaces;
using PersonalWebPageManagementSystem.Infrastructure.Persistence;

namespace PersonalWebPageManagementSystem.Infrastructure.Repositories
{
    public class ResumeRepository : IResumeRepository
    {
        private readonly PersonalWebPageContext _context;

        public ResumeRepository(PersonalWebPageContext context)
        {
            _context = context;
        }

        public async Task<Resume> GetByIdAsync(Guid id)
        {
            return await _context.Resume
                .Include(r => r.Profile)
                .Include(r => r.EmploymentHistory)
                .Include(r => r.Education)
                .Include(r => r.Skills)
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<IEnumerable<Resume>> GetAllAsync()
        {
            return await _context.Resume
                .Include(r => r.Profile)
                .Include(r => r.EmploymentHistory)
                .Include(r => r.Education)
                .Include(r => r.Skills)
                .ToListAsync();
        }

        public Task<Resume> CreateAsync(Resume resume)
        {
            _context.Resume.Add(resume);
            return Task.FromResult(resume);
        }

        public Task<Resume> UpdateAsync(Resume resume)
        {
            _context.Entry(resume).State = EntityState.Modified;
            return Task.FromResult(resume);
        }

        public async Task DeleteAsync(Guid id)
        {
            var resume = await _context.Resume.FindAsync(id);
            if (resume != null)
            {
                _context.Resume.Remove(resume);
            }
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.Resume.AnyAsync(r => r.Id == id);
        }
    }
}
