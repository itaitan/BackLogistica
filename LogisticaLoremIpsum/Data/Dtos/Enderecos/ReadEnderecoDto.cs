using LogisticaLoremIpsum.Models;
using System.ComponentModel.DataAnnotations;

namespace LogisticaLoremIpsum.Data.Dtos.Enderecos
{
    public class ReadEnderecoDto
    {
        [Key]
        [Required]
        public int id { get; set; }    

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

        

    }
}
