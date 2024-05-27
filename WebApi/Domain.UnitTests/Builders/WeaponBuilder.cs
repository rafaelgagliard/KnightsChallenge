using Domain.Entities;

namespace Domain.UnitTests.Builders
{
    public static class WeaponBuilder
    {
        public static Weapon Build() =>
            new Weapon { Name = "Espada", Mod = 3, Attr = "strength", Equipped = false };
    }
}
