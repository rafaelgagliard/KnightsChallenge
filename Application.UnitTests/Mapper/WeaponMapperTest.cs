using Application.Mapper;
using Application.UnitTests.Builders;
using Domain.UnitTests.Builders;

namespace Application.UnitTests.Mapper
{
    [TestFixture()]
    public class WeaponMapperTest
    {
        [Test]
        public void ValidateRequestToWeapon()
        {
            var weapon = WeaponBuilder.Build();
            var weaponRequest = WeaponRequestBuilder.Build();

            Assert.That(weapon, Is.EqualTo(weaponRequest.RequestToWeapon()));
        }
    }
}
