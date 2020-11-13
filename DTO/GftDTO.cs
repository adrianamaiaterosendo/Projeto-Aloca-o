using System.ComponentModel.DataAnnotations;

namespace Desafio_MVC.DTO
{
    public class GftDTO
    {
        [Required]
        public int Id { get; set; }
        [Required (ErrorMessage="CEP é obrigatório!")]
        public string Cep { get; set; }
        [Required(ErrorMessage="Cidade é obrigatório!")]
        public string Cidade { get; set; }
        [Required(ErrorMessage="Endereço é obrigatório!")]
        public string Endereco { get; set; }
        [Required(ErrorMessage="Estado é obrigatório!")]
        public string Estado { get; set; }
        [Required(ErrorMessage="Nome da Unidade é obrigatório!")]
        [StringLength(100, ErrorMessage="Nome muito grande! Tente menor!")]
        [MinLength(5, ErrorMessage="Nome muito pequeno! Tente maior!")]
        public string Nome { get; set; }
        [Required(ErrorMessage="Telefone é obrigatório!")]
        [Phone (ErrorMessage = "Deve ser digitado um telefone válido")]
        public string Telefone { get; set; }
        public bool Ativa {get; set; }
    }
}