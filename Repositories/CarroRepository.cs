
using System.Collections.Generic;
using ApiCalculo.Data;
using ApiCalculo.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ApiCalculo.Repositories
{
    public class CarroRepository : ICarro
    {
        private readonly DataContext _context;

        public CarroRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Carro Carro)
        {
            this._context.Carros.Add(Carro);
            this._context.SaveChanges();
        }

        public void Delete(Carro Carro)
        {
            var carro = this._context.Carros.FirstOrDefault(x=>x.Id == Carro.Id && x.Nome.Equals(Carro.Nome));
            if(carro != null) this._context.Entry(carro).State = EntityState.Deleted;
            this._context.SaveChanges();
        }

        public IList<Carro> GetAll()
        {
            return this._context.Carros.ToList();
        }

        public Carro GetById(int id)
        {
           return this._context.Carros.FirstOrDefault(x=>x.Id == id);
        }

        public void Update(Carro Carro)
        {
            var carro = this._context.Carros.FirstOrDefault(x=>x.Id == Carro.Id);
            if(carro != null) this._context.Entry(Carro).State = EntityState.Modified;
            this._context.SaveChanges();
        }
    }
}