using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LogisticaLoremIpsum.Models
{
    public class Cliente
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

        [JsonIgnore]
        public virtual List<Endereco> Endereco { get; set; }

    }
}
