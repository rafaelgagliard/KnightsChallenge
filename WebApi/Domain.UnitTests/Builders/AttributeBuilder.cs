namespace Domain.UnitTests.Builders
{
    public static class AttributeBuilder
    {
        public static Entities.Attributes Build() =>
            new Entities.Attributes
            {
                charisma = 50,
                constitution = 50,
                dexterity = 50,
                intelligence = 50,
                strength = 50,
                wisdom = 50
            };
    }
}