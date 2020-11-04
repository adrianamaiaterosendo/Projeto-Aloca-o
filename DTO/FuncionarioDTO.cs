using System.ComponentModel.DataAnnotations;
using System;
namespace Desafio_MVC.DTO

{
    public class FuncionarioDTO
    {
        [Required]
        public int Id { get; set; }
        
        [Required (ErrorMessage="Cargo é obrigatório!")]
        public string Cargo { get; set; }
         [Required (ErrorMessage="Início de WA é obrigatório!")]
        public DateTime InicioWa { get; set; }
        [Required (ErrorMessage="Nome é obrigatório!")]
        [StringLength(100, ErrorMessage="Nome muito grande! Tente menor!")]
        [MinLength(5, ErrorMessage="Nome muito pequeno! Tente maior!")]
        public string Nome { get; set; }
         [Required (ErrorMessage="Número de Matrícula é obrigatório!")]
        public string Matricula { get; set; }
        public string TerminoWa { get; set; }
         [Required (ErrorMessage="Telefone é obrigatório!")]
         [Phone(ErrorMessage="Telefone inválido!")]
        public string Telefone { get; set; }
         [Required (ErrorMessage="E-mail é obrigatório!")]
         [EmailAddress(ErrorMessage="E-mail inválido!")]
        public string Email { get; set; }
        public bool Alocado {get; set;}
    }
}