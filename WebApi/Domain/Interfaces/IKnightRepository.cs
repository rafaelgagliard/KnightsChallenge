using Domain.Entities;
using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IKnightRepository
    {
        Task<IEnumerable<Knight>> GetKnights(Expression<Func<Knight, bool>> predicate);
        Task<Knight> GetKnightById(int id);

        Task<Knight> CreateKnights(Knight knight);

        Task DeleteKnight(int id);
        Task SendHallOfHeroes(int id);
        Task UpdateKnight(int id, string nickName);

        Task<bool> Exists(int id);
    }
}
