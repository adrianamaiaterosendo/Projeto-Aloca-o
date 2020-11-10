using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Desafio_MVC.Models;
using Desafio_MVC.Data;
using Desafio_MVC.DTO;
using Microsoft.EntityFrameworkCore;

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

                  
        public ICollection <Tecnologia> Tecnologia {get; set;}
        public int TecnologiaID {get; set;}

        public Gft Gft { get; set; }

        public Vaga Vaga {get; set; } 

        
    }
}