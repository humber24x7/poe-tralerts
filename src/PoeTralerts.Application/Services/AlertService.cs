using PoeTralerts.Application.Interfaces;
using PoeTralerts.Domain.Entities;

namespace PoeTralerts.Application.Services
{
    public class AlertService(IApplicationDbContext dbContext)
    {
        public async Task<Alert> GetById(int id)
        {
            return await dbContext.Alerts.FindAsync(id);
        }
    }
}