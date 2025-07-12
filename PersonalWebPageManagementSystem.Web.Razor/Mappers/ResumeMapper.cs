using PersonalWebPageManagementSystem.Application.DTOs;
using PersonalWebPageManagementSystem.Web.Razor.ViewModels;

namespace PersonalWebPageManagementSystem.Web.Razor.Mappers
{
    public static class ResumeMapper
    {
        public static ResumeVm ToViewModel(ResumeDto dto)
        {
            if (dto == null) return null;

            return new ResumeVm
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
                Profile = dto.Profile != null ? new ResumeProfileVm
                {
                    Id = dto.Profile.Id,
                    Title = dto.Profile.Title,
                    Description = dto.Profile.Description
                } : null,
                EmploymentHistory = dto.EmploymentHistory?.Select(e => new ResumeExperienceVm
                {
                    Id = e.Id,
                    JobTitle = e.JobTitle,
                    Employer = e.Employer,
                    City = e.City,
                    FromDate = e.FromDate,
                    ToDate = e.ToDate
                }).ToList() ?? new List<ResumeExperienceVm>(),
                Education = dto.Education?.Select(e => new ResumeEducationVm
                {
                    Id = e.Id,
                    Institution = e.Institution,
                    Degree = e.Degree,
                    FieldOfStudy = e.FieldOfStudy,
                    FromDate = e.FromDate,
                    ToDate = e.ToDate
                }).ToList() ?? new List<ResumeEducationVm>(),
                Skills = dto.Skills?.Select(s => new ResumeSkillVm
                {
                    Id = s.Id,
                    Title = s.Title,
                    Description = s.Description,
                    Level = s.Level
                }).ToList() ?? new List<ResumeSkillVm>()
            };
        }

        public static ResumeDto ToDto(ResumeVm viewModel)
        {
            if (viewModel == null) return null;

            return new ResumeDto
            {
                Id = viewModel.Id,
                Description = viewModel.Description,
                Image = viewModel.Image,
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                Email = viewModel.Email,
                PhoneNumber = viewModel.PhoneNumber,
                Country = viewModel.Country,
                City = viewModel.City,
                Address = viewModel.Address,
                PostalCode = viewModel.PostalCode,
                Profile = viewModel.Profile != null ? new ResumeProfileDto
                {
                    Id = viewModel.Profile.Id,
                    Title = viewModel.Profile.Title,
                    Description = viewModel.Profile.Description
                } : null,
                EmploymentHistory = viewModel.EmploymentHistory?.Select(e => new ResumeExperienceDto
                {
                    Id = e.Id,
                    JobTitle = e.JobTitle,
                    Employer = e.Employer,
                    City = e.City,
                    FromDate = e.FromDate,
                    ToDate = e.ToDate
                }).ToList() ?? new List<ResumeExperienceDto>(),
                Education = viewModel.Education?.Select(e => new ResumeEducationDto
                {
                    Id = e.Id,
                    Institution = e.Institution,
                    Degree = e.Degree,
                    FieldOfStudy = e.FieldOfStudy,
                    FromDate = e.FromDate,
                    ToDate = e.ToDate
                }).ToList() ?? new List<ResumeEducationDto>(),
                Skills = viewModel.Skills?.Select(s => new ResumeSkillDto
                {
                    Id = s.Id,
                    Title = s.Title,
                    Description = s.Description,
                    Level = s.Level
                }).ToList() ?? new List<ResumeSkillDto>()
            };
        }
    }
}
