using System.ComponentModel.DataAnnotations;
using ApiCalculo.Models.Interfaces;

namespace ApiCalculo.Models
{
    public class Trip : ITrip
    {
        public Trip(int carroId, int tempoViagem, int velocidadeMedia)
        {
            CarroID = carroId;
            TempoViagem = tempoViagem;
            VelocidadeMedia = velocidadeMedia;
        }
        [Required]
        public int CarroID { get; private set; }
        [Required]
        [Range(1, uint.MaxValue)]
        public int TempoViagem { get; private set; }
        [Required]
        [Range(1, uint.MaxValue)]
        public int VelocidadeMedia { get; private set; }

        public ITripResult CalcularTrip(Carro carro)
        {
            return new TripResult(carro,
                        this.TempoViagem,
                        this.VelocidadeMedia,
                        this.DistanciFinal(),
                        this.Litros(carro));
        }

        public int DistanciFinal() => this.TempoViagem * VelocidadeMedia;
        
        public double Litros(Carro Carro) => DistanciFinal() / Carro.Rendimento;
       
         
    }
}