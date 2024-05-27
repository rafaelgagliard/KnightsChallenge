using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repositories
{
    public class KnightRepository : IKnightRepository
    {
        public readonly KnightsContext _knightsContext;

        public KnightRepository(KnightsContext knightsContext)
        {
            _knightsContext = knightsContext;
        }

        public async Task<IEnumerable<Knight>> GetKnights(Expression<Func<Knight, bool>> predicate) =>
            await _knightsContext.Knights
                .Include(a => a.Attributes)
                .Include(w => w.Weapons)
                .Where(predicate)
                .ToListAsync();

        public async Task<Knight> GetKnightById(int id) =>
            await _knightsContext.Knights
                .Include(a => a.Attributes)
                .Include(w => w.Weapons)
                .SingleAsync(c => c.Id.Equals(id));

        public async Task<Knight> CreateKnights(Knight knight)
        {
            _knightsContext.Knights.Add(knight);

            await _knightsContext.SaveChangesAsync();

            return knight;
        }

        public async Task DeleteKnight(int id)
        {
            var knight = await _knightsContext.Knights.SingleAsync(c => c.Id.Equals(id));

            _knightsContext.Knights.Remove(knight);

            await _knightsContext.SaveChangesAsync();
        }

        public async Task SendHallOfHeroes(int id)
        {
            var knight = await _knightsContext.Knights.SingleAsync(c => c.Id.Equals(id));
            
            knight.IsHero = true;

            await _knightsContext.SaveChangesAsync();
        }

        public async Task UpdateKnight(int id, string nickName)
        {
            var knight = await _knightsContext.Knights.SingleAsync(c => c.Id.Equals(id));

            knight.NickName = nickName;

            await _knightsContext.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id) =>
            await _knightsContext.Knights.AnyAsync(c=> c.Id.Equals(id));
    }
}
