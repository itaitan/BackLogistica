using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LogisticaLoremIpsum.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int id { get; set; }

        
        public int id_cliente { get; set; }

        [Required(ErrorMessage = "O Campo cep é obrigatorio")]        
        public string cep { get; set; }

        [Required(ErrorMessage = "O Campo logradouro é obrigatorio")]
        public string logradouro { get; set; }

        [Required(ErrorMessage = "O Campo numero é obrigatorio")]       
        public int numero { get; set; }

        public string bairro { get; set; }
        public string complemento { get; set; }

        [Required(ErrorMessage = "O Campo UF é obrigatorio")]        
        public string uf { get; set; }

        [JsonIgnore]
        public virtual Cliente cliente { get; set; }

        
    }
}
