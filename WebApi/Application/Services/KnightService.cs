using Application.Interfaces;
using Application.Mapper;
using Application.ViewModel;
using Application.ViewModel.Request;
using Application.ViewModel.Response;
using Domain.Interfaces;

namespace Application.Services
{
    public class KnightService : IKnightService
    {
        private readonly IKnightRepository _knightRepository;

        public KnightService(IKnightRepository knightRepository)
        {
            _knightRepository = knightRepository;
        }

        public async Task<List<KnightResponse>> GetKnights(string? filter)
        {
            var heroes = filter?.Equals("heroes");
            return (await _knightRepository
                .GetKnights(c=> c.IsHero.Equals(heroes) || c.IsHero))
                .KnightsToResponse();
        }


        public async Task<KnightResponse> GetKnightById(int id) =>
            (await _knightRepository.GetKnightById(id)).KnightToResponse();

        public async Task<KnightResponse> CreateKnights(KnightRequest knightViewModel) =>
            (await _knightRepository.CreateKnights(knightViewModel.RequestToKnight()))
                .KnightToResponse();

        public async Task SendHallOfHeroes(int id) =>
            await _knightRepository.SendHallOfHeroes(id);

        public async Task UpdateKnight(int id, string nickName) =>
            await _knightRepository.UpdateKnight(id, nickName);

        public async Task<bool> Exists(int id) =>
            await _knightRepository.Exists(id);
    }
}