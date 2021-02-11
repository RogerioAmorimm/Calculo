using System.ComponentModel.DataAnnotations;

namespace ApiCalculo.Models
{
    public class Carro 
    {

        [Key]
        public int Id { get; set; }

        [MinLength(3, ErrorMessage = "Quantidade minima de caracteres é 3")]
        [MaxLength(15, ErrorMessage = "Quantidade maxima de caracteres é 15")]
        public string Marca { get;  set; }

        [Required(ErrorMessage = "")]
        [MinLength(3, ErrorMessage = "Quantidade minima de caracteres é 3")]
        [MaxLength(15, ErrorMessage = "Quantidade maxima de caracteres é 15")]

        public string Nome { get;  set; }

        [Required]
        [Range(0.1, double.MaxValue, ErrorMessage = "Redimento dever ser maior que 0")]
        public double Rendimento { get;  set; }
    }
}