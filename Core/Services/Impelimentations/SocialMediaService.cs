using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Services.Interfaces;
using DataLayer.Contexts;
using DataLayer.Entities.SiteAgg;
using Microsoft.EntityFrameworkCore;

namespace Core.Services.Impelimentations
{
    public class SocialMediaService : ISocialMediaService
    {
        #region Constructor

        private readonly DataBaseContext  _context;

        public SocialMediaService(DataBaseContext context)
        {
            _context = context;
        }

        #endregion

        public async Task<SocialMedia> GetDetails(int id)
        {
            return await _context.SocialMedia.FindAsync(id);
        }

        public async Task Edit(SocialMedia command)
        {
            var social = await _context.SocialMedia.FindAsync(command.Id);

            social.Edit(command.Title,command.Url,command.CssClass);

            await _context.SaveChangesAsync();

        }

        public async Task<List<SocialMedia>> GetAll()
        {
            return await _context.SocialMedia.ToListAsync();
        }

        public async Task Delete(int id)
        {
            var social = await _context.SocialMedia.FindAsync(id);

            _context.SocialMedia.Remove(social);

            await _context.SaveChangesAsync();
        }
    }
}