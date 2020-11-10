using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using Desafio_MVC.Models;

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
        [MinLength(5, ErrorMessage="Nome muito pequeno! Tente maior! Tente nome e sobrenome.")]
        public string Nome { get; set; }
        [Required (ErrorMessage="Número de Matrícula é obrigatório!")]
        [Range(1, 10, ErrorMessage = "Número da matrícula deve ser entre 1 até 10 números")]
        public string Matricula { get; set; }
        public string TerminoWa { get; set; }
        [Required (ErrorMessage="Telefone é obrigatório!")]
        [Phone(ErrorMessage="Telefone inválido!")]
        public string Telefone { get; set; }
        [Required (ErrorMessage="E-mail é obrigatório!")]
        [EmailAddress(ErrorMessage="E-mail inválido!")]
        public string Email { get; set; }
        
        [Required (ErrorMessage="Tecnologia é obrigatório!")]
        public int TecnologiaId {get; set;}

        [Required (ErrorMessage="Ao menos uma tecnologia é obrigatório!")]
        public List<Tecnologia> TecnologiasSelecionadas {get; set;}

        [Required (ErrorMessage="Ao menos uma tecnologia é obrigatório!")]
        public string TecnologiasSelecionadasId {get; set;}


        [Required (ErrorMessage="Unidade GFT é obrigatório! Selecione uma unidade!")]
        public int GftId { get; set; }
        
        public int VagaId {get; set; }

    }
}