using Application.ViewModel.Request;

namespace Application.UnitTests.Builders
{
    public static class AttributeRequestBuilder
    {
        public static AttributeRequest Build() =>
            new AttributeRequest()
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
