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
        
        [HttpPost]
        public IActionResult Salvar (VagaDTO VagaTemporaria){
            ViewBag.Tecnologia = database.Tecnologias.ToList();
            ViewBag.Gft = database.Gfts.ToList();
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
            return View("../Wa/CadastrarVaga");}

             public IActionResult Atualizar (VagaDTO VagaTemporaria){
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
                ViewBag.Tecnologia = database.Tecnologias.ToList();
                ViewBag.Gft = database.Gfts.ToList();
                return View ("../wa/EditarVaga");}
        }

        public IActionResult Deletar (int id){
            ViewBag.Vaga = database.Vagas.ToList();
            var vaga = database.Vagas.First(vag => vag.Id == id);
            database.Vagas.Remove(vaga);
            database.SaveChanges();
            return RedirectToAction ("Vagas","wa");}


    }
}
