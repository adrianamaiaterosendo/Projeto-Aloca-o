using System;
namespace Desafio_MVC.Models
{
    public class Alocacao
    {
        public int Id {get; set; }
        public DateTime InicioAlocacao {get; set; }
        public Vaga Vaga {get; set; }
        public Funcionario Funcionario {get; set; }

    }
}