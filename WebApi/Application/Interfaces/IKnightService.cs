using Application.ViewModel;
using Application.ViewModel.Request;
using Application.ViewModel.Response;

namespace Application.Interfaces
{
    public interface IKnightService
    {
        Task<List<KnightResponse>> GetKnights(string? filter);
        Task<KnightResponse> GetKnightById(int id);
        Task SendHallOfHeroes(int id);

        Task<KnightResponse> CreateKnights(KnightRequest knightViewModel);

        Task UpdateKnight(int id, string nickName);

        Task<bool> Exists(int id);
    }
}
