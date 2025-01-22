using Microsoft.EntityFrameworkCore;
using PoeTralerts.Application.Interfaces;
using PoeTralerts.Domain.Entities;
using System.Reflection;

namespace PoeTralerts.Infrastructure
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options), IApplicationDbContext
    {
        public DbSet<Alert> Alerts => Set<Alert>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}