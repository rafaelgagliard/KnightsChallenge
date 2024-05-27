using Domain.Entities;
using Domain.UnitTests.Builders;

namespace Domain.Rules.Tests
{
    [TestFixture()]
    public class KnightRulesTests
    {
        [Test()]
        public void AtackTest()
        {
            Assert.True(KnightsBuilder.Build().Atack().Equals(60));

        }


        [Test()]
        [TestCase(2024, 1, 1, 0)]
        [TestCase(2014, 1, 1, 10)]
        [TestCase(2004, 1, 1, 20)]
        [TestCase(2000, 1, 1, 24)]
        public void AgeTest(int year, int month, int day, int expected)
        {
            Knight knight = new Knight() { Birthday = new DateTime(year, month, day, 0, 0, 0, DateTimeKind.Utc) };
            Assert.True(knight.Age().Equals(expected));
        }


        [Test()]
        [TestCase(2024, 1, 1, 0)]
        [TestCase(2014, 1, 1, 265)]
        [TestCase(2004, 1, 1, 1149)]
        [TestCase(2000, 1, 1, 1503)]
        public void ExperienceTest(int year, int month, int day, int expected)
        {
            Knight knight = new Knight() { Birthday = new DateTime(year, month, day, 0, 0, 0, DateTimeKind.Utc) };
            Assert.True(knight.Experience().Equals(expected));
        }
    }
}