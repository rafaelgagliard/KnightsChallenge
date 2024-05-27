using Application.ViewModel.Response;

namespace Application.UnitTests.Builders
{
    public static class KnightResponseBuilder
    {
        public static KnightResponse Build() =>
            new KnightResponse()
            {
                Nome = "Teste Gagliard",
                Armas = 1,
                Ataque = 60,
                Atributo = "strength",
                Experiencia = 265,
                Idade = 10
            };
    }
}
