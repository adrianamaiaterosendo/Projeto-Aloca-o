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

namespace Desafio_MVC.Controllers
{
    public class FuncionarioController : Controller
    {   
        private readonly ApplicationDbContext database;

        public FuncionarioController(ApplicationDbContext database){
            this.database = database;
        }

         [HttpPost]    
         public IActionResult Salvar (FuncionarioDTO funcionarioTemporario){
                ViewBag.Tecnologia = database.Tecnologias.ToList();
                ViewBag.Gft = database.Gfts.ToList();
                if(ModelState.IsValid){
                    Funcionario funcionario = new Funcionario();
                    funcionario.Cargo = funcionarioTemporario.Cargo;
                    funcionario.InicioWa = funcionarioTemporario.InicioWa;
                    funcionario.Nome = funcionarioTemporario.Nome;
                    funcionario.Matricula = funcionarioTemporario.Matricula;
                    funcionario.TerminoWa = funcionarioTemporario.TerminoWa;
                    funcionario.Telefone = funcionarioTemporario.Telefone;
                    funcionario.Email = funcionarioTemporario.Email;
                    funcionario.Alocado = false;
                    funcionario.Tecnologia = database.Tecnologias.First(tecnologia => tecnologia.Id == funcionarioTemporario.TecnologiaId );
                    funcionario.Gft = database.Gfts.First(gft => gft.Id == funcionarioTemporario.GftId );
                    database.Funcionarios.Add(funcionario);
                    database.SaveChanges();
                    return RedirectToAction ("Funcionarios","wa");
                }else {      
                    return View("../Wa/Cadastrar");}
        }

        public IActionResult Atualizar (FuncionarioDTO funcionarioTemporario){
             if(ModelState.IsValid){
                var funcionario = database.Funcionarios.First(fun => fun.Id == funcionarioTemporario.Id);
                funcionario.Cargo = funcionarioTemporario.Cargo;
                funcionario.InicioWa = funcionarioTemporario.InicioWa;
                funcionario.Nome = funcionarioTemporario.Nome;
                funcionario.Matricula = funcionarioTemporario.Matricula;
                funcionario.TerminoWa = funcionarioTemporario.TerminoWa;
                funcionario.Telefone = funcionarioTemporario.Telefone;
                funcionario.Email = funcionarioTemporario.Email;
                funcionario.Tecnologia = database.Tecnologias.First(tecnologia => tecnologia.Id == funcionarioTemporario.TecnologiaId );
                funcionario.Gft = database.Gfts.First(gft => gft.Id == funcionarioTemporario.GftId );
                database.SaveChanges();
                 return RedirectToAction ("Funcionarios","wa");
            }else { 
                ViewBag.Tecnologia = database.Tecnologias.ToList();
                ViewBag.Gft = database.Gfts.ToList();
                return View ("../wa/EditarFuncionario");}
        }

        public IActionResult Deletar (int id){
            ViewBag.Funcionario = database.Funcionarios.ToList();
            var funcionario = database.Funcionarios.First(con => con.Id == id);
            database.Funcionarios.Remove(funcionario);
            database.SaveChanges();
            return RedirectToAction ("Funcionarios","wa");}


    }
}