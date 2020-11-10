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

        public IActionResult PopularBD (){
            var popular = database.Publicacoes.ToList();
            Publicacao p1 = new Publicacao();
            p1.Preenchido = false;
            database.Add (p1);
            database.SaveChanges();


            if(p1.Preenchido == false && p1.Id == 1){
                  

            Gft g1 = new Gft();
            g1.Cep = "06454-000";
            g1.Cidade = "Barueri";
            g1.Endereco = "Alameda Rio Negro, 585";
            g1.Estado = "São Paulo";
            g1.Nome = "GFT Alphaville";
            g1.Telefone = "(11) 2176-3253";

            Gft g2 = new Gft();
            g2.Cep = "80250-210";
            g2.Cidade = "Curitiba";
            g2.Endereco = "Av. Sete de Setembro, 2451 - 6º andar - Rebouças";
            g2.Estado = "Paraná";
            g2.Nome = "GFT Curitiba";
            g2.Telefone = "(41) 4009-5700";

            Gft g3 = new Gft();
            g3.Cep = "18095-450";
            g3.Cidade = "Sorocaba";
            g3.Endereco = "Av. São Francisco, 98";
            g3.Estado = "São Paulo";
            g3.Nome = "GFT Sorocaba";
            g3.Telefone = "(11) 2176-3253";

            List<Gft> gftList = new List <Gft> ();
            gftList.Add (g1);
            gftList.Add (g2);
            gftList.Add (g3);

            database.AddRange(gftList);
            database.SaveChanges();
                
            }else{

                return View("Index");

            }
         

             
            return View("Index");        
        
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

        public IActionResult Funcionarios(){
            var Funcionario = database.Funcionarios.Include(f => f.Tecnologia).Include(f => f.Gft).Where(f => f.Alocado == false).ToList();
            return View(Funcionario);
        }

        public IActionResult Cadastrar(){
            ViewBag.Tecnologia = database.Tecnologias.ToList();
            ViewBag.Gft = database.Gfts.ToList();
            return View();
        }

        public IActionResult Vagas(){
            var Vaga = database.Vagas.Include(v => v.Tecnologia).Include(v => v.Gft).Where(v => v.Disponivel == true && v.Quantidade >= 1).ToList();
            return View(Vaga);
        }

        public IActionResult CadastrarVaga(){
            ViewBag.Tecnologia = database.Tecnologias.ToList();
            ViewBag.Gft = database.Gfts.ToList();
            return View();
        }

          public IActionResult Alocacao(){

            ViewBag.Vaga = (from v in database.Vagas
                               select v.Projeto).Distinct();
            ViewBag.Funcionario = database.Funcionarios.Where(f => f.Alocado == false).ToList();
            ViewBag.Vaga = database.Vagas.Where(v => v.Disponivel == true && v.Quantidade >= 1).ToList();
            var Alocacao = database.Alocacoes.Include(a => a.Funcionario).Include(a => a.Vaga).ToList();
            return View(Alocacao);
        }

         public IActionResult Alocar(){
            ViewBag.Vaga = database.Vagas.Where(v => v.Disponivel == true).ToList();
            ViewBag.Funcionario = database.Funcionarios.Where(f => f.Alocado == false).ToList();
            
            return View();}
    

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

            public IActionResult EditarFuncionario (int id){
            ViewBag.Tecnologia = database.Tecnologias.ToList();
            ViewBag.Gft = database.Gfts.ToList();
            ViewBag.FuncionarioTecnologia = database.FuncionarioTecnologias.ToList();
            var funcionario = database.Funcionarios.Include(f => f.Tecnologia).Include(f => f.Gft).First(f => f.Id == id);
            FuncionarioDTO funcionarioView = new FuncionarioDTO();
            funcionarioView.Id = funcionario.Id;
            funcionarioView.Cargo = funcionario.Cargo;
            funcionarioView.InicioWa = funcionario.InicioWa;
            funcionarioView.Nome = funcionario.Nome;
            funcionarioView.Matricula = funcionario.Matricula;
            funcionarioView.TerminoWa = funcionario.TerminoWa;
            funcionarioView.Telefone = funcionario.Telefone;
            funcionarioView.Email = funcionario.Email;         
           
            funcionarioView.GftId = funcionario.Gft.Id;
            ViewBag.Tecnologia = database.Tecnologias.ToList();
            ViewBag.Gft = database.Gfts.ToList();
            
            return View (funcionarioView);
            }
        
            public IActionResult EditarVaga (int id){
            var vaga = database.Vagas.Include(v => v.Tecnologia).Include(v => v.Gft).First(v => v.Id == id);
            VagaDTO vagaView = new VagaDTO();
            vagaView.Id = vaga.Id;
            vagaView.DataAbertura = vaga.DataAbertura;
            vagaView.Codigo = vaga.Codigo;
            vagaView.Cliente = vaga.Cliente;
            vagaView.Cargo = vaga.Cargo;
            vagaView.Descricao = vaga.Descricao;
            vagaView.Projeto = vaga.Projeto;
            vagaView.Quantidade = vaga.Quantidade;
            vagaView.GftId = vaga.Gft.Id;
            vagaView.TecnologiaId = vaga.Tecnologia.Id;
            ViewBag.Tecnologia = database.Tecnologias.ToList();
            ViewBag.Gft = database.Gfts.ToList();
            return View (vagaView);
        }

    }
}