using LogisticaLoremIpsum.Models;
using System.ComponentModel.DataAnnotations;

namespace LogisticaLoremIpsum.Data.Dtos
{
    public class ReadClienteDto
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatorio")]
        public string nome { get; set; }
        [Required(ErrorMessage = "O data de nascimento é obrigatorio")]
        public string dataNascimento { get; set; }
        [Required(ErrorMessage = "O sexo é obrigatorio")]
        public string sexo { get; set; }

        public List<Endereco> Endereco { get; set; }
    }
}
