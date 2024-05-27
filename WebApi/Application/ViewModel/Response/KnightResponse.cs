using Domain.Rules;

namespace Application.ViewModel.Response
{
    public class KnightResponse : BaseResponse
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Armas { get; set; }
        public string Atributo { get; set; }
        public int Ataque { get; set; }
        public double Experiencia { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is KnightResponse response &&
                   Nome == response.Nome &&
                   Idade == response.Idade &&
                   Armas == response.Armas &&
                   Atributo == response.Atributo &&
                   Ataque == response.Ataque &&
                   Experiencia == response.Experiencia;
        }
    }
}
