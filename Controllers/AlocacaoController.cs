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


namespace Desafio_MVC.Controllers
{
    public class AlocacaoController : Controller
    {

    private readonly ApplicationDbContext database;

    public AlocacaoController(ApplicationDbContext database){
            this.database = database;
    }
     
     [HttpPost]
        public IActionResult Salvar (AlocacaoDTO AlocacaoTemporaria){
            if(ModelState.IsValid){
                Alocacao alocacao = new Alocacao();
                alocacao.InicioAlocacao = AlocacaoTemporaria.InicioAlocacao;
                alocacao.Vaga = database.Vagas.Where(v => v.Quantidade >= 1 && v.Disponivel == true).First(vaga => vaga.Id == AlocacaoTemporaria.VagaId );
                alocacao.Funcionario = database.Funcionarios.Where(f => f.Alocado == false).First(funcionario => funcionario.Id == AlocacaoTemporaria.FuncionarioId );  
                database.Alocacoes.Add(alocacao);
                database.SaveChanges();

                var funcionario = database.Funcionarios.First(func => func.Id == AlocacaoTemporaria.FuncionarioId);
                funcionario.Alocado = true;

                var vaga = database.Vagas.First(vag => vag.Id == AlocacaoTemporaria.VagaId);
                if(vaga.Quantidade <= 1){
                   vaga.Quantidade = vaga.Quantidade - 1; 
                   vaga.Disponivel = false; 

                }else{vaga.Quantidade = vaga.Quantidade - 1;};
                            
                                
                              
                
                database.SaveChanges();
                return RedirectToAction ("Alocacao", "Wa");

            }
            return View("../Wa/Alocar");}
        
        public IActionResult Deletar (int id){

            
             
            var alocar = database.Alocacoes.Include(f => f.Funcionario).Include(v => v.Vaga).First(a => a.Id == id); 
            //IQueryable<Funcionario> funcionario;
            //Funcionario funcionario = new Funcionario();
            var funcionario = database.Funcionarios.First(f => f.Id == alocar.Funcionario.Id);
            funcionario.Alocado = false;
            //Vaga vaga = new Vaga();
            var vaga = database.Vagas.First (v => v.Id == alocar.Vaga.Id);
            vaga.Quantidade = vaga.Quantidade + 1;
            vaga.Disponivel = true;
            
                                                         
            database.Alocacoes.Remove(alocar);
            database.SaveChanges();

            return RedirectToAction ("Alocacao","wa");}


    }
        
}
