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
    public class WaController : Controller
    {

        private readonly ApplicationDbContext database;

        public WaController (ApplicationDbContext database){
            this.database = database;
        }
        public IActionResult Index()
        {
            return View();
        }  
        public IActionResult UnidadesGFT(){
            var gft = database.Gfts.ToList();
            return View(gft);
        }
        public IActionResult CadastrarGFT(){
            return View();
        }
        public IActionResult Tecnologias(){
            var tecnologia = database.Tecnologias.ToList();
            return View(tecnologia);
        }

        public IActionResult CadastrarTecnologia(){
            return View();
        }

            public IActionResult EditarUnidadeGFT (int id){
            var unidadeGft = database.Gfts.First(gft => gft.Id == id);
            GftDTO gftView = new GftDTO();
            gftView.Id = unidadeGft.Id;
            gftView.Cep = unidadeGft.Cep;
            gftView.Cidade = unidadeGft.Cidade;
            gftView.Endereco = unidadeGft.Endereco;
            gftView.Estado = unidadeGft.Estado;
            gftView.Nome = unidadeGft.Nome;
            gftView.Telefone = unidadeGft.Telefone;
            return View (gftView);
        }
            public IActionResult EditarTecnologia (int id){
            var tecnologia = database.Tecnologias.First(tec => tec.Id == id);
            TecnologiaDTO tecnologiaView = new TecnologiaDTO();
            tecnologiaView.Id = tecnologia.Id;
            tecnologiaView.NomeTec = tecnologia.NomeTec;
            tecnologiaView.TipoTec = tecnologia.TipoTec;
            
            return View (tecnologiaView);
        }
    

    }
}