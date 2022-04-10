using System.ComponentModel.DataAnnotations;

namespace LogisticaLoremIpsum.Data.Dtos
{
    public class UpdateClienteDto
    {
        
        [Required(ErrorMessage = "O nome é obrigatorio")]
        public string nome { get; set; }
        [Required(ErrorMessage = "O data de nascimento é obrigatorio")]
        public string dataNascimento { get; set; }
        [Required(ErrorMessage = "O sexo é obrigatorio")]
        public string sexo { get; set; }
    }
}
