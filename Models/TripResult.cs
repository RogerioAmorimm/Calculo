using ApiCalculo.Models.Interfaces;

namespace ApiCalculo.Models
{
    public class TripResult : ITripResult
    {
        public TripResult()
        {
            
        }

        public TripResult(Carro carro, int tempoViagem, int velocidadeMedia, int distanciaPercorrida, double quantidadeCombustivel)
        {
            Carro = carro;
            TempoViagem = tempoViagem;
            VelocidadeMedia = velocidadeMedia;
            DistanciaPercorrida = distanciaPercorrida;
            QuantidadeCombustivel = quantidadeCombustivel;
        }

        public Carro Carro { get; set; }

        public int TempoViagem { get; set; }

        public int VelocidadeMedia { get; set; }

        public  int DistanciaPercorrida { get; set; }

        public double QuantidadeCombustivel { get; set; }
    }
} 