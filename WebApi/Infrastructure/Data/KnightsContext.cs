using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public sealed class KnightsContext : DbContext
    {
        public KnightsContext(DbContextOptions<KnightsContext> options) : base(options) { }

        public DbSet<Knight> Knights { get; set; }
        public DbSet<Attributes> Attributes { get; set; }
        public DbSet<Weapon> Weapons { get; set; }


    }
}