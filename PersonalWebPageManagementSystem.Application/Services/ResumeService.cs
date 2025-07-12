using PersonalWebPageManagementSystem.Application.DTOs;
using PersonalWebPageManagementSystem.Domain.Entities;
using PersonalWebPageManagementSystem.Domain.Interfaces;

namespace PersonalWebPageManagementSystem.Application.Services
{
    public class ResumeService : IResumeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ResumeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResumeDto> GetResumeByIdAsync(Guid id)
        {
            var resume = await _unitOfWork.Resumes.GetByIdAsync(id);
            return MapToDto(resume);
        }

        public async Task<IEnumerable<ResumeDto>> GetAllResumesAsync()
        {
            var resumes = await _unitOfWork.Resumes.GetAllAsync();
            return resumes.Select(MapToDto);
        }

        public async Task<ResumeDto> CreateResumeAsync(ResumeDto resumeDto)
        {
            var resume = MapToEntity(resumeDto);
            var createdResume = await _unitOfWork.Resumes.CreateAsync(resume);
            await _unitOfWork.SaveChangesAsync();
            return MapToDto(createdResume);
        }

        public async Task<ResumeDto> UpdateResumeAsync(ResumeDto resumeDto)
        {
            var resume = MapToEntity(resumeDto);
            var updatedResume = await _unitOfWork.Resumes.UpdateAsync(resume);
            await _unitOfWork.SaveChangesAsync();
            return MapToDto(updatedResume);
        }

        public async Task DeleteResumeAsync(Guid id)
        {
            await _unitOfWork.Resumes.DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> ResumeExistsAsync(Guid id)
        {
            return await _unitOfWork.Resumes.ExistsAsync(id);
        }

        private ResumeDto MapToDto(Resume resume)
        {
            if (resume == null) return null;

            return new ResumeDto
            {
                Id = resume.Id,
                Description = resume.Description,
                Image = resume.Image,
                FirstName = resume.FirstName,
                LastName = resume.LastName,
                Email = resume.Email,
                PhoneNumber = resume.PhoneNumber,
                Country = resume.Country,
                City = resume.City,
                Address = resume.Address,
                PostalCode = resume.PostalCode,
                Profile = resume.Profile != null ? new ResumeProfileDto
                {
                    Id = resume.Profile.Id,
                    Title = resume.Profile.Title,
                    Description = resume.Profile.Description
                } : null,
                EmploymentHistory = resume.EmploymentHistory?.Select(e => new ResumeExperienceDto
                {
                    Id = e.Id,
                    JobTitle = e.JobTitle,
                    Employer = e.Employer,
                    City = e.City,
                    FromDate = e.FromDate,
                    ToDate = e.ToDate
                }).ToList() ?? new List<ResumeExperienceDto>(),
                Education = resume.Education?.Select(e => new ResumeEducationDto
                {
                    Id = e.Id,
                    Institution = e.Institution,
                    Degree = e.Degree,
                    FieldOfStudy = e.FieldOfStudy,
                    FromDate = e.FromDate,
                    ToDate = e.ToDate
                }).ToList() ?? new List<ResumeEducationDto>(),
                Skills = resume.Skills?.Select(s => new ResumeSkillDto
                {
                    Id = s.Id,
                    Title = s.Title,
                    Description = s.Description,
                    Level = s.Level
                }).ToList() ?? new List<ResumeSkillDto>()
            };
        }

        private Resume MapToEntity(ResumeDto dto)
        {
            return new Resume
            {
                Id = dto.Id,
                Description = dto.Description,
                Image = dto.Image,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
                Country = dto.Country,
                City = dto.City,
                Address = dto.Address,
                PostalCode = dto.PostalCode,
                Profile = dto.Profile != null ? new ResumeProfile
                {
                    Id = dto.Profile.Id,
                    Title = dto.Profile.Title,
                    Description = dto.Profile.Description
                } : null,
                EmploymentHistory = dto.EmploymentHistory?.Select(e => new ResumeExperience
                {
                    Id = e.Id,
                    JobTitle = e.JobTitle,
                    Employer = e.Employer,
                    City = e.City,
                    FromDate = e.FromDate,
                    ToDate = e.ToDate
                }).ToList(),
                Education = dto.Education?.Select(e => new ResumeEducation
                {
                    Id = e.Id,
                    Institution = e.Institution,
                    Degree = e.Degree,
                    FieldOfStudy = e.FieldOfStudy,
                    FromDate = e.FromDate,
                    ToDate = e.ToDate
                }).ToList(),
                Skills = dto.Skills?.Select(s => new ResumeSkill
                {
                    Id = s.Id,
                    Title = s.Title,
                    Description = s.Description,
                    Level = s.Level
                }).ToList()
            };
        }
    }
}
