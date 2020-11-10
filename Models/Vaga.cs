using System;
namespace Desafio_MVC.Models
{
    public class Vaga
    {

        public int Id { get; set; }
        public DateTime DataAbertura { get; set; }
        public string Codigo { get; set; }
        public string Cliente {get; set;}
        public string Cargo { get; set; }
        public string Descricao { get; set; }
        public string Projeto { get; set; }
        public int Quantidade { get; set; }

        public Gft Gft {get; set; }
        public Tecnologia Tecnologia {get; set; }
        public bool Disponivel {get; set; }
       
        

    }
        
}
