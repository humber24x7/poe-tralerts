using Microsoft.EntityFrameworkCore;
using PoeTralerts.Domain.Entities;

namespace PoeTralerts.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Alert> Alerts { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}