using Application.ViewModel.Request;

namespace Application.UnitTests.Builders
{
    public static class WeaponRequestBuilder
    {
        public static WeaponRequest Build() =>
            new WeaponRequest()
            {
                Name = "Espada",
                Mod = 3,
                Attr = "strength"
            };
    }
}
