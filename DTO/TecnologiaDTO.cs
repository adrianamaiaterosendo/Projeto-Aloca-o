using System.ComponentModel.DataAnnotations;
using System;

namespace Desafio_MVC.DTO
{
    public class TecnologiaDTO
    {

        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage="Nome da Tecnologia é obrigatório!")]
        [StringLength(100, ErrorMessage="Nome muito grande! Tente menor!")]
        [MinLength(5, ErrorMessage="Nome muito pequeno! Tente maior!")]
        public string NomeTec {get; set;}

        [Required(ErrorMessage="Tipo da Tecnologia é obrigatório!")]
        [StringLength(100, ErrorMessage="Nome muito grande! Tente menor!")]
        [MinLength(5, ErrorMessage="Nome muito pequeno! Tente maior!")]
        public string TipoTec {get; set;}
    }
}