using System.ComponentModel.DataAnnotations;
using System;

namespace Desafio_MVC.DTO
{
    public class AlocacaoDTO
    {

        [Required]
        public int Id {get; set; }
        [Required(ErrorMessage="Data de início da Alocação é obrigatório!")]
        [DataType(DataType.Date, ErrorMessage = "Favor digite uma data válida")]
        public DateTime InicioAlocacao {get; set; }
        [Required(ErrorMessage="Seleção de vaga é obrigatório")]
        public int VagaId {get; set; }
        [Required(ErrorMessage="Seleção de funcionário é obrigatório!")]
        public int FuncionarioId {get; set; }

        public int FuncionarioTecnologiaId {get; set; }

    }
}