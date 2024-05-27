using Domain.Entities;

namespace Domain.UnitTests.Builders
{
    public static class KnightsBuilder
    {
        public static Knight Build() =>
            new Knight()
            {
                Name = "Teste Gagliard",
                Birthday = birthDay,
                Weapons = WeaponsBuilder.Build(),
                Attributes = AttributeBuilder.Build(),
                KeyAttribute = "strength"
            };

        private static DateTimeOffset birthDay { get => new DateTime(2014, 01, 01, 0, 0, 0, DateTimeKind.Utc); }
    }
}
