using Application.ViewModel.Request;

namespace Application.UnitTests.Builders
{
    public static class WeaponsRequestBuilder
    {
        public static List<WeaponRequest> Build() =>
            new List<WeaponRequest> { WeaponRequestBuilder.Build() };
    }
}
