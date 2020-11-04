using System;

namespace Desafio_MVC.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Cargo { get; set; }
        public DateTime InicioWa { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string TerminoWa { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool Alocado {get; set;}

        public Tecnologia Tecnologia {get; set;}

        public Gft Gft { get; set; }

        public Vaga Vaga {get; set; }

        
    }
}