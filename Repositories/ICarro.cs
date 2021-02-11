using System.Collections.Generic;
using ApiCalculo.Models;

namespace ApiCalculo.Repositories
{
    public interface ICarro
    {
        void Add(Carro Carro);
        void Update(Carro Carro);
        void Delete(Carro Carro);
        IList<Carro> GetAll();
        Carro GetById(int id);

        
    }
   
}