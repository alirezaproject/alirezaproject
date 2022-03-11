using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DTOs.ResumeAgg.Experience;

namespace Core.Services.Interfaces
{
    public interface IResumeService
    {
        Task CreateExperienceAsync(CreateExperienceDto command);
        Task<List<ExperienceDto>> GetAllExperienceAsync();
        Task<List<ExperienceDto>> GetAllExperienceByLanguageAsync(string culture);
        Task<EditExperienceDto> GetExperienceDetailsAsync(int experienceId);
        Task EditExperienceDetailsAsync(EditExperienceDto command);

    }
}
