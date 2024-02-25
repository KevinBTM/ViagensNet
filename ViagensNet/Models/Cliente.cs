using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ViagensNet.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Data de nascimento")]
        public DateTime DataNascimento { get; set; }
        
    }
}
