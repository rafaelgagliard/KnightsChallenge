using Domain.Entities;

namespace Domain.UnitTests.Builders
{
    public static class WeaponsBuilder
    {
        public static List<Weapon> Build() =>
            new List<Weapon> { WeaponBuilder.Build() };
    }
}
