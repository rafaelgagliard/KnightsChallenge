using Domain.UnitTests.Builders;
using Domain.Validations;

namespace Domain.UnitTests.Validations
{
    public class Tests
    {

        [Test]
        public void KnightDeveSerValido()
        {
            var knight = KnightsBuilder.Build();
            var validador = new KnightsValidations();
            var result = validador.Validate(knight);

            Assert.True(result.IsValid);

        }

        [Test]
        [TestCase("")]
        [TestCase("testenomegrande_testenomegrande_testenomegrande_testenomegrande_testenomegrande_testenomegrande_testenomegrande_testenomegrande_testenomegrande_testenomegrande_testenomegrande_testenomegrande_testenomegrande")]
        public void KnightDeveSerInvalido(string nome)
        {
            var knight = KnightsBuilder.Build();
            knight.Name = nome;

            var validador = new KnightsValidations();
            var result = validador.Validate(knight);

            Assert.False(result.IsValid);
        }


    }
}