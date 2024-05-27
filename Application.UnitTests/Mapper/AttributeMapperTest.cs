using Application.Mapper;
using Application.UnitTests.Builders;
using Domain.UnitTests.Builders;

namespace Application.UnitTests.Mapper
{
    [TestFixture()]
    public class AttributeMapperTest
    {
        [Test()]
        public void ValidateRequestToAttributes()
        {
            var attributeRequest = AttributeRequestBuilder.Build();
            var attribute = AttributeBuilder.Build();

            Assert.That(attribute, Is.EqualTo(attributeRequest.RequestToAttributes()));
        }
    }
}
