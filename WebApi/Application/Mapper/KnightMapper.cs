using Application.ViewModel.Request;
using Application.ViewModel.Response;
using Domain.Entities;
using Domain.Rules;

namespace Application.Mapper
{
    public static class KnightMapper
    {
        public static Knight RequestToKnight(this KnightRequest knightRequest)
        {
            List<Weapon> weapons = new List<Weapon>();

            foreach (var weaponRequest in knightRequest.Weapons)
                weapons.Add(weaponRequest.RequestToWeapon());

            return new Knight()
            {
                Attributes = knightRequest.Attributes.RequestToAttributes(),
                Birthday = knightRequest.Birthday,
                KeyAttribute = knightRequest.KeyAttribute,
                Name = knightRequest.Name,
                NickName = knightRequest.NickName,
                Weapons = weapons,
                IsHero = false
            };
        }

        public static KnightResponse KnightToResponse(this Knight knight)
        {
            return new KnightResponse()
            {
                Nome = knight.Name,
                Idade = knight.Age(),
                Armas = knight.Weapons.Count,
                Atributo = knight.KeyAttribute,
                Ataque = knight.Atack(),
                Experiencia = knight.Experience()
            };
        }

        public static List<KnightResponse> KnightsToResponse(this IEnumerable<Knight> knights)
        {
            List<KnightResponse> knightsResponse = new List<KnightResponse>();
            foreach (var item in knights)
                knightsResponse.Add(item.KnightToResponse());

            return knightsResponse;
        }
    }
}
