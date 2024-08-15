using System.ComponentModel.DataAnnotations;

namespace Faturamento.API.Business.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor informe o nome do produto")]
        public string ProductName { get; set; }
    }
}
