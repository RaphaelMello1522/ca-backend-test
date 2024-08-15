using System.ComponentModel.DataAnnotations;

namespace Faturamento.API.Business.Models
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor informe o nome do cliente")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Por favor informe o email do cliente")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor informe o endereço do cliente")]
        public string Address { get; set; }
    }
}
