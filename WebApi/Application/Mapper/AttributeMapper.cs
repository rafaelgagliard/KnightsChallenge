using Application.ViewModel.Request;
using Domain.Entities;

namespace Application.Mapper
{
    public static class AttributeMapper
    {
        public static Attributes RequestToAttributes(this AttributeRequest attributeRequest) =>
            new Attributes()
            {
                charisma = attributeRequest.charisma,
                constitution = attributeRequest.constitution,
                dexterity = attributeRequest.dexterity,
                intelligence = attributeRequest.intelligence,
                strength = attributeRequest.strength,
                wisdom = attributeRequest.wisdom
            };

    }
}
