using System.Collections.Generic;
using ApiCalculo.Models;

namespace ApiCalculo.Models.Interfaces
{
    public interface ITrip
    {
        ITripResult CalcularTrip(Carro carro);
    }
   
}