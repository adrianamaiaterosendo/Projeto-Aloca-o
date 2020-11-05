using System.ComponentModel.DataAnnotations;
using System;
namespace Desafio_MVC.DTO
{
    public class VagaDTO
    {
        [Required]
        public int Id { get; set; }
        [Required (ErrorMessage= "Data de abertura é obrigatório!")]
        public DateTime DataAbertura { get; set; }
        [Required (ErrorMessage= "Código da Vaga é obrigatório!")]
        public string Codigo { get; set; }
        [Required (ErrorMessage= "Nome do cliente é obrigatório")]
        [StringLength(100, ErrorMessage="Nome muito grande! Tente menor!")]
        [MinLength(5, ErrorMessage="Nome muito pequeno! Tente maior!")]
        public string Cliente {get; set;}
        [Required (ErrorMessage= "Cargo é obrigatório")]
        [StringLength(100, ErrorMessage="Nome do cargo muito grande! Tente menor!")]
        [MinLength(5, ErrorMessage="Nome do cargo muito pequeno! Tente maior!")]
        public string Cargo { get; set; }
        [Required (ErrorMessage= "Descrição da vaga é obrigatório")]
        [StringLength(200, ErrorMessage="Descrição muito grande! Tente menor!")]
        [MinLength(5, ErrorMessage="Descrição muito pequeno! Tente maior!")]
        public string Descricao { get; set; }
        [Required (ErrorMessage= "Nome do Projeto é obrigatório")]
        [StringLength(200, ErrorMessage="Nome do Projeto muito grande! Tente menor!")]
        [MinLength(5, ErrorMessage="Nome do Projeto muito pequeno! Tente maior!")]
        public string Projeto { get; set; }
        [Required (ErrorMessage= "Quantidade de vagas é obrigatório!")]
        public int Quantidade { get; set; }
        [Required (ErrorMessage= "Unidade da GFT é obrigatório!")]
        public int GftId {get; set; }
        [Required (ErrorMessage= "Tecnologia da vaga é obrigatório!")]
        public int TecnologiaId {get; set; }
    }
}