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
using Microsoft.AspNetCore.Authorization;

namespace Desafio_MVC.Controllers
{
    public class VagaController : Controller
    {
        
        private readonly ApplicationDbContext database;

        public VagaController (ApplicationDbContext database){
            this.database = database;
        }

        [Authorize(Policy = "TemCargo")]
        
        [HttpPost]
        public IActionResult Salvar (VagaDTO VagaTemporaria){
            ViewBag.Tecnologia = database.Tecnologias.Where(t => t.Ativa == true).ToList();
            ViewBag.Gft = database.Gfts.Where(g => g.Ativa == true).ToList();
            if(ModelState.IsValid){
                Vaga vaga = new Vaga();
                vaga.DataAbertura = VagaTemporaria.DataAbertura;
                vaga.Codigo = VagaTemporaria.Codigo;
                vaga.Cliente = VagaTemporaria.Cliente;
                vaga.Cargo = VagaTemporaria.Cargo;
                vaga.Descricao = VagaTemporaria.Descricao;
                vaga.Projeto = VagaTemporaria.Projeto;
                vaga.Quantidade = VagaTemporaria.Quantidade;
                vaga.Gft = database.Gfts.First(gft => gft.Id == VagaTemporaria.GftId );
                vaga.Tecnologia = database.Tecnologias.First(tecnologia => tecnologia.Id == VagaTemporaria.TecnologiaId );
                vaga.Disponivel = true;             

                database.Vagas.Add(vaga);
                database.SaveChanges();
                return RedirectToAction ("Vagas", "Wa");

            }
               ViewBag.Tecnologia = database.Tecnologias.Where(t => t.Ativa == true).ToList();
               ViewBag.Gft = database.Gfts.Where(g => g.Ativa == true).ToList();
            return View("../Wa/CadastrarVaga");}

            [Authorize(Policy = "TemCargo")]

             public IActionResult Atualizar (VagaDTO VagaTemporaria){
                ViewBag.Tecnologia = database.Tecnologias.Where(t => t.Ativa == true).ToList();
                ViewBag.Gft = database.Gfts.Where(g => g.Ativa == true).ToList();
            
             if(ModelState.IsValid){
                                                 
                var vaga = database.Vagas.First(vag => vag.Id == VagaTemporaria.Id);
                vaga.DataAbertura = VagaTemporaria.DataAbertura;
                vaga.Codigo = VagaTemporaria.Codigo;
                vaga.Cliente = VagaTemporaria.Cliente;
                vaga.Cargo = VagaTemporaria.Cargo;
                vaga.Descricao = VagaTemporaria.Descricao;
                vaga.Projeto = VagaTemporaria.Projeto;
                vaga.Quantidade = VagaTemporaria.Quantidade;                
                vaga.Tecnologia = database.Tecnologias.First(tecnologia => tecnologia.Id == VagaTemporaria.TecnologiaId );
                vaga.Gft = database.Gfts.First(gft => gft.Id == VagaTemporaria.GftId );
                database.SaveChanges();
                 return RedirectToAction ("Vagas","wa");
            }else { 
                ViewBag.Tecnologia = database.Tecnologias.Where(t => t.Ativa == true).ToList();
                ViewBag.Gft = database.Gfts.Where(g => g.Ativa == true).ToList();
                return View ("../wa/EditarVaga");}
        }

        [Authorize(Policy = "TemCargo")]

        public IActionResult Deletar (int id){
            ViewBag.Vaga = database.Vagas.ToList();
            var vaga = database.Vagas.First(vag => vag.Id == id);
            vaga.Disponivel = false;            
            database.SaveChanges();
            return RedirectToAction ("Vagas","wa");}


    }
}
