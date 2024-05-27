using Application.ViewModel.Request;

namespace Application.UnitTests.Builders
{
    public static class KnightRequestBuilder
    {
        public static KnightRequest Build() =>
            new KnightRequest()
            {
                Name = "Teste Gagliard",
                Birthday = birthDay,
                Weapons = WeaponsRequestBuilder.Build(),
                Attributes = AttributeRequestBuilder.Build(),
                KeyAttribute = "strength"
            };

        private static DateTimeOffset birthDay { get => new DateTime(2014, 01, 01, 0, 0, 0, DateTimeKind.Utc); }
    }
}
