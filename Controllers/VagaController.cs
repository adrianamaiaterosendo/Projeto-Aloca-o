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

namespace Desafio_MVC.Controllers
{
    public class VagaController : Controller
    {
        
        private readonly ApplicationDbContext database;

        public VagaController (ApplicationDbContext database){
            this.database = database;
        }
        
    }
}