using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Core.DTOs.ResumeAgg.Experience;
using Core.Services.Interfaces;
using DataLayer.Contexts;
using DataLayer.Entities.ResumeAgg;
using Microsoft.EntityFrameworkCore;

namespace Core.Services.Impelimentations
{
    public class ResumeService : IResumeService
    {
        #region Constructor

        private readonly DataBaseContext _context;

        public ResumeService(DataBaseContext context)
        {
            _context = context;
        }

        #endregion

        public async Task CreateExperienceAsync(CreateExperienceDto command)
        {
            var exp = new Experience(command.Title, command.Percentage, command.IsRight, command.LanguageId);
            await _context.Experiences.AddAsync(exp);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ExperienceDto>> GetAllExperienceAsync()
        {
            return await _context.Experiences.Include(x => x.Language).Select(s => new ExperienceDto()
            {
                Title = s.Title,
                Language = s.Language.LangName,
                Percentage = s.Percentage,
                IsRight = s.IsRight,
                ExperienceId = s.ExperienceId
            }).ToListAsync();
        }

        public async Task<List<ExperienceDto>> GetAllExperienceByLanguageAsync(string culture)
        {
            return await _context.Experiences.Include(x => x.Language).Where(x => x.Language.LangName == culture).Select(s => new ExperienceDto()
            {
                Title = s.Title,
                Language = s.Language.LangName,
                Percentage = s.Percentage,
                IsRight = s.IsRight,
                ExperienceId = s.ExperienceId

            }).ToListAsync();
        }

        public async Task<EditExperienceDto> GetExperienceDetailsAsync(int experienceId)
        {
            return await _context.Experiences.Where(x => x.ExperienceId == experienceId).Select(s =>
                new EditExperienceDto()
                {
                    Title = s.Title,
                    Percentage = s.Percentage,
                    IsRight = s.IsRight,
                    ExperienceId = s.ExperienceId,
                    LanguageId = s.LanguageId

                }).FirstOrDefaultAsync();
        }

        public async Task EditExperienceDetailsAsync(EditExperienceDto command)
        {
            var exp = await _context.Experiences.FindAsync(command.ExperienceId);

            exp.Edit(command.Title,command.Percentage,command.IsRight);

            await _context.SaveChangesAsync();
        }
    }
}