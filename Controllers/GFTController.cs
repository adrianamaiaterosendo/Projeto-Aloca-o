using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Desafio_MVC.Models;
using System.ComponentModel.DataAnnotations;
using Desafio_MVC.DTO;
using Desafio_MVC.Data;
using Microsoft.AspNetCore.Authorization;

namespace Desafio_MVC.Controllers
{
    public class GFTController : Controller
    {

        private readonly ApplicationDbContext database;

        public GFTController(ApplicationDbContext database){
            this.database = database;
        }

        [Authorize(Policy = "TemCargo")]
        [HttpPost]
        public IActionResult Salvar (GftDTO GftTemporario){
            if(ModelState.IsValid){
                Gft Gft = new Gft();
                Gft.Cep = GftTemporario.Cep;
                Gft.Cidade = GftTemporario.Cidade;
                Gft.Endereco = GftTemporario.Endereco;
                Gft.Estado = GftTemporario.Estado;
                Gft.Nome = GftTemporario.Nome;
                Gft.Telefone = GftTemporario.Telefone;
                database.Gfts.Add(Gft);
                database.SaveChanges();
                return RedirectToAction ("UnidadesGFT", "Wa");

            }
            return View("../Wa/CadastrarGFT");}

        [Authorize(Policy = "TemCargo")]
         public IActionResult Atualizar(GftDTO gftTemporario){
            if(ModelState.IsValid){
                var gft = database.Gfts.First(uni => uni.Id == gftTemporario.Id);
                gft.Cep = gftTemporario.Cep;
                gft.Cidade = gftTemporario.Cidade;
                gft.Endereco = gftTemporario.Endereco;
                gft.Estado = gftTemporario.Estado;
                gft.Nome = gftTemporario.Nome;
                gft.Telefone = gftTemporario.Telefone;
                database.SaveChanges();
                return RedirectToAction ("UnidadesGFT", "Wa");
            }else { return RedirectToAction ("UnidadesGFT", "Wa");}}

        [Authorize(Policy = "TemCargo")]
        
        public IActionResult Deletar (int id){
            ViewBag.Gfts = database.Gfts.ToList();
            var Gft = database.Gfts.First(uni => uni.Id == id);                   
            
                database.Gfts.Remove(Gft);
                database.SaveChanges();
                        
            return RedirectToAction("UnidadesGFT", "Wa");}
    }
}