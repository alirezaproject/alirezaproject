using System.Collections.Generic;
using System.Threading.Tasks;
using DataLayer.Entities.SiteAgg;

namespace Core.Services.Interfaces
{
    public interface ISocialMediaService
    {
        Task<SocialMedia> GetDetails(int id);
        Task Edit(SocialMedia socialMedia);
        Task<List<SocialMedia>> GetAll();
        Task Delete(int id);
    }
}