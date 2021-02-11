using ApiCalculo.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCalculo.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Carro> Carros { get; set; }
        
    }
}