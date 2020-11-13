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
using Microsoft.AspNetCore.Authorization;



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

            Tecnologia t1 = new Tecnologia();
            t1.NomeTec = "CSharp e DotNet";
            t1.TipoTec = "BackEnd";

            Tecnologia t2 = new Tecnologia();
            t2.NomeTec = "Java10";
            t2.TipoTec = "BackEnd";

            Tecnologia t3 = new Tecnologia();
            t3.NomeTec = "Amazon AWS";
            t3.TipoTec = "Cloud";

            Tecnologia t4 = new Tecnologia();
            t4.NomeTec = "Azure Microsoft";
            t4.TipoTec = "Cloud";

            Tecnologia t5 = new Tecnologia();
            t5.NomeTec = "Google Cloud";
            t5.TipoTec = "Cloud";

            Tecnologia t6 = new Tecnologia();
            t6.NomeTec = "Python";
            t6.TipoTec = "BackEnd";

            Tecnologia t7 = new Tecnologia();
            t7.NomeTec = "Angular";
            t7.TipoTec = "Front-end";

            Tecnologia t8 = new Tecnologia();
            t8.NomeTec = "HTML";
            t8.TipoTec = "Front-end";

            Tecnologia t9 = new Tecnologia();
            t9.NomeTec = "JavaScript";
            t9.TipoTec = "Front-end e BackEnd";

            Tecnologia t10 = new Tecnologia();
            t10.NomeTec = "Apex";
            t10.TipoTec = "SalesForce";

            List<Tecnologia> tecList = new List <Tecnologia> ();
            tecList.Add (t1);
            tecList.Add (t2);
            tecList.Add (t3);
            tecList.Add (t4);
            tecList.Add (t5);
            tecList.Add (t6);
            tecList.Add (t7);
            tecList.Add (t8);
            tecList.Add (t9);
            tecList.Add (t10);

            database.AddRange(tecList);
            database.SaveChanges();

            ViewBag.Tecnologia = database.Tecnologias.ToList();
            ViewBag.Gft = database.Gfts.ToList();
            ViewBag.Funcionario = database.Funcionarios.ToList();

            Funcionario f1 = new Funcionario();
            f1.Cargo = "Analista de Sistemas Jr";
            f1.InicioWa = DateTime.Now;
            f1.Nome = "Jess Bezos";
            f1.Matricula = "800250";
            f1.TerminoWa = DateTime.Now.AddDays(15).ToString();
            f1.Telefone = "11-2585-6596";
            f1.Email = "jessbezos@teste.com.br";
            f1.Alocado = false;
            var gft = database.Gfts.First(g => g.Nome == "GFT Alphaville");
            f1.Gft = database.Gfts.Where(g => g.Nome == "GFT Alphaville").First (g => g.Id == gft.Id);
            database.Add(f1);
            database.SaveChanges();

            var tec = database.Tecnologias.First(t => t.NomeTec == "Amazon AWS");
            var func = database.Funcionarios.First(t => t.Nome == "Jess Bezos");
            var tec2 = database.Tecnologias.First(t => t.NomeTec == "Java10");
            var func2 = database.Funcionarios.First(t => t.Nome == "Jess Bezos");

            FuncionarioTecnologia ft1 = new FuncionarioTecnologia();
            ft1.Tecnologia = database.Tecnologias.Where(t => t.NomeTec == "Amazon AWS").First(t => t.Id == tec.Id);
            ft1.Funcionario = database.Funcionarios.Where(f => f.Nome == "Jess Bezos").First (f => f.Id == func.Id);
            FuncionarioTecnologia ft2 = new FuncionarioTecnologia();            
            ft2.Tecnologia = database.Tecnologias.Where(t => t.NomeTec == "Java10").First(t => t.Id == tec2.Id);
            ft2.Funcionario = database.Funcionarios.Where(f => f.Nome == "Jess Bezos").First (f => f.Id == func2.Id);
            database.Add(ft1);
            database.SaveChanges();
            database.Add(ft2);
            database.SaveChanges();

            Funcionario f2 = new Funcionario();
            f2.Cargo = "Analista de Sistemas Sr";
            f2.InicioWa = DateTime.Now;
            f2.Nome = "Bill Gates";
            f2.Matricula = "800251";
            f2.TerminoWa = DateTime.Now.AddDays(15).ToString();
            f2.Telefone = "11-2585-6593";
            f2.Email = "billgates@teste.com.br";
            f2.Alocado = false;
            var gftGates = database.Gfts.First(g => g.Nome == "GFT Sorocaba");
            f2.Gft = database.Gfts.Where(g => g.Nome == "GFT Sorocaba").First (g => g.Id == gftGates.Id);
            database.Add(f2);
            database.SaveChanges();

            var tecbill = database.Tecnologias.First(t => t.NomeTec == "Azure Microsoft");
            var funcbill = database.Funcionarios.First(t => t.Nome == "Bill Gates");
            var tec2bill = database.Tecnologias.First(t => t.NomeTec == "CSharp e DotNet");
            var func2bill = database.Funcionarios.First(t => t.Nome == "Bill Gates");

            FuncionarioTecnologia ft3 = new FuncionarioTecnologia();
            ft3.Tecnologia = database.Tecnologias.Where(t => t.NomeTec == "Azure Microsoft").First(t => t.Id == tecbill.Id);
            ft3.Funcionario = database.Funcionarios.Where(f => f.Nome == "Bill Gates").First (f => f.Id == funcbill.Id);
            FuncionarioTecnologia ft4 = new FuncionarioTecnologia();            
            ft4.Tecnologia = database.Tecnologias.Where(t => t.NomeTec == "CSharp e DotNet").First(t => t.Id == tec2bill.Id);
            ft4.Funcionario = database.Funcionarios.Where(f => f.Nome == "Bill Gates").First (f => f.Id == func2bill.Id);
            database.Add(ft3);
            database.SaveChanges();
            database.Add(ft4);
            database.SaveChanges();

            Funcionario f3 = new Funcionario();
            f3.Cargo = "Analista de Sistemas Pleno";
            f3.InicioWa = DateTime.Now;
            f3.Nome = "Larry Page";
            f3.Matricula = "800252";
            f3.TerminoWa = DateTime.Now.AddDays(15).ToString();
            f3.Telefone = "11-2585-6594";
            f3.Email = "larypage@teste.com.br";
            f3.Alocado = false;
            var gftPage = database.Gfts.First(g => g.Nome == "GFT Sorocaba");
            f3.Gft = database.Gfts.Where(g => g.Nome == "GFT Sorocaba").First (g => g.Id == gftPage.Id);
            database.Add(f3);
            database.SaveChanges();

            var tecpage = database.Tecnologias.First(t => t.NomeTec == "Google Cloud");
            var funcpage = database.Funcionarios.First(t => t.Nome == "Larry Page");
            var tec2page = database.Tecnologias.First(t => t.NomeTec == "Angular");
            var func2page = database.Funcionarios.First(t => t.Nome == "Larry Page");

            FuncionarioTecnologia ft5 = new FuncionarioTecnologia();
            ft5.Tecnologia = database.Tecnologias.Where(t => t.NomeTec == "Google Cloud").First(t => t.Id == tecpage.Id);
            ft5.Funcionario = database.Funcionarios.Where(f => f.Nome == "Larry Page").First (f => f.Id == tecpage.Id);
            FuncionarioTecnologia ft6 = new FuncionarioTecnologia();            
            ft6.Tecnologia = database.Tecnologias.Where(t => t.NomeTec == "Angular").First(t => t.Id == tec2page.Id);
            ft6.Funcionario = database.Funcionarios.Where(f => f.Nome == "Larry Page").First (f => f.Id == func2page.Id);
            database.Add(ft5);
            database.SaveChanges();
            database.Add(ft6);
            database.SaveChanges();

            
            Funcionario f4 = new Funcionario();
            f4.Cargo = "Analista de Sistemas Pleno";
            f4.InicioWa = DateTime.Now;
            f4.Nome = "Marc Benioff";
            f4.Matricula = "800253";
            f4.TerminoWa = DateTime.Now.AddDays(15).ToString();
            f4.Telefone = "11-2585-6595";
            f4.Email = "marcbenioff@teste.com.br";
            f4.Alocado = false;
            var gftMarc = database.Gfts.First(g => g.Nome == "GFT Curitiba");
            f4.Gft = database.Gfts.Where(g => g.Nome == "GFT Curitiba").First (g => g.Id == gftMarc.Id);
            database.Add(f4);
            database.SaveChanges();

            var tecmarc = database.Tecnologias.First(t => t.NomeTec == "Apex");
            var funcmarc = database.Funcionarios.First(t => t.Nome == "Marc Benioff");
            var tec2marc = database.Tecnologias.First(t => t.NomeTec == "JavaScript");
            var func2marc = database.Funcionarios.First(t => t.Nome == "Marc Benioff");

            FuncionarioTecnologia ft7 = new FuncionarioTecnologia();
            ft7.Tecnologia = database.Tecnologias.Where(t => t.NomeTec == "Apex").First(t => t.Id == tecmarc.Id);
            ft7.Funcionario = database.Funcionarios.Where(f => f.Nome == "Marc Benioff").First (f => f.Id == tecmarc.Id);
            FuncionarioTecnologia ft8 = new FuncionarioTecnologia();            
            ft8.Tecnologia = database.Tecnologias.Where(t => t.NomeTec == "JavaScript").First(t => t.Id == tec2marc.Id);
            ft8.Funcionario = database.Funcionarios.Where(f => f.Nome == "Marc Benioff").First (f => f.Id == func2marc.Id);
            database.Add(ft7);
            database.SaveChanges();
            database.Add(ft8);
            database.SaveChanges();

            Vaga v1 = new Vaga();
            v1.DataAbertura = DateTime.Now;
            v1.Codigo = "#ItauMigração";
            v1.Cliente = "Itau Unibanco";
            v1.Cargo = "Analista de Sistemas Jr";
            v1.Descricao = "Fazer migrações de API";
            v1.Projeto = "Migrações";
            v1.Quantidade = 2;
            var gftv1 = database.Gfts.First(g => g.Nome == "GFT Alphaville");
            v1.Gft = database.Gfts.Where(g => g.Nome == "GFT Alphaville").First (g => g.Id == gftv1.Id);
            var tecv1 = database.Tecnologias.First (t => t.NomeTec == "Amazon AWS");
            v1.Tecnologia = database.Tecnologias.Where(t => t.NomeTec == "Amazon AWS").First(t => t.Id == tecv1.Id);
            v1.Disponivel = true;

             Vaga v2 = new Vaga();
            v2.DataAbertura = DateTime.Now;
            v2.Codigo = "#BCOLegado";
            v2.Cliente = "Banco Curitibano";
            v2.Cargo = "Analista de Sistemas Senior";
            v2.Descricao = "Atuar na manutenção de legado";
            v2.Projeto = "Legado";
            v2.Quantidade = 1;
            var gftv2 = database.Gfts.First(g => g.Nome == "GFT Curitiba");
            v2.Gft = database.Gfts.Where(g => g.Nome == "GFT Curitiba").First (g => g.Id == gftv2.Id);
            var tecv2 = database.Tecnologias.First (t => t.NomeTec == "CSharp e DotNet");
            v2.Tecnologia = database.Tecnologias.Where(t => t.NomeTec == "CSharp e DotNet").First(t => t.Id == tecv2.Id);
            v2.Disponivel = true;

            Vaga v3 = new Vaga();
            v3.DataAbertura = DateTime.Now;
            v3.Codigo = "#SantForce";
            v3.Cliente = "Banco Santander";
            v3.Cargo = "Analista de Sistemas Senior";
            v3.Descricao = "Atuar em SalesForce";
            v3.Projeto = "Sales-Force";
            v3.Quantidade = 5;
            var gftv3 = database.Gfts.First(g => g.Nome == "GFT Sorocaba");
            v3.Gft = database.Gfts.Where(g => g.Nome == "GFT Sorocaba").First (g => g.Id == gftv3.Id);
            var tecv3 = database.Tecnologias.First (t => t.NomeTec == "Apex");
            v3.Tecnologia = database.Tecnologias.Where(t => t.NomeTec == "Apex").First(t => t.Id == tecv3.Id);
            v3.Disponivel = true;

            database.AddRange(v1,v2,v3);
            database.SaveChanges();
                
            }else{

                return View("Index");

            }
         

             
            return View("Index");        
        
        }

        public IActionResult TesteBD (){
           
            ViewBag.Tecnologia = database.Tecnologias.ToList();
            ViewBag.Gft = database.Gfts.ToList();
            ViewBag.Funcionario = database.Funcionarios.ToList();

            var delete = database.Tecnologias.Where(tec => tec.Ativa == false);
            database.Remove(delete);
            database.SaveChanges();

                      
           
        
            return Content ("tudo certo");
        }
        
        public IActionResult UnidadesGFT(){
            var gft = database.Gfts.Where(g => g.Ativa == true).ToList();
            return View(gft);
        }

        [Authorize(Policy = "TemCargo")]
        public IActionResult CadastrarGFT(){
            return View();
        }
        public IActionResult Tecnologias(){
            var tecnologia = database.Tecnologias.Where(t => t.Ativa == true).ToList();
            return View(tecnologia);
        }

        [Authorize(Policy = "TemCargo")]
        public IActionResult CadastrarTecnologia(){
            return View();
        }

        public IActionResult Funcionarios(){


            ViewBag.Funcionario = database.Funcionarios.ToList(); 
            ViewBag.FuncionarioTecnologia = database.FuncionarioTecnologias.ToList();

           
            var Funcionario = database.FuncionarioTecnologias.Include(f => f.Tecnologia).Include(f => f.Funcionario.Gft).Where(f => f.Funcionario.Alocado == false).ToList();
            var Gft = database.Funcionarios.Include(g => g.Gft).ToList();
            foreach (var item in Funcionario)
            {
                item.Funcionario.Gft = database.Gfts.First(g => g.Id == item.Funcionario.Gft.Id);
            }

            // FuncionarioTecnologiaDTO funcionarioTecnologiaDTO = new FuncionarioTecnologiaDTO();
            // List<FuncionarioTecnologia> tecnologias =  database.FuncionarioTecnologias.ToList();
            // foreach (var tec in tecnologias){
            //     if (funcionarioTecnologiaDTO.Tecnologias == null){
            //         funcionarioTecnologiaDTO.Tecnologias = tec.Tecnologia.NomeTec; 
            //     }else{
            //         funcionarioTecnologiaDTO.Tecnologias += " | "+ tec.Tecnologia.NomeTec; 
            //     }
                
            // };
            // ViewBag.TecnologiasFuncionario = funcionarioTecnologiaDTO;

            return View(Funcionario);
        }

        [Authorize(Policy = "TemCargo")]
        public IActionResult Cadastrar(){
            ViewBag.Tecnologia = database.Tecnologias.ToList();
            ViewBag.Gft = database.Gfts.ToList();
            return View();
        }

        public IActionResult Vagas(){
            var Vaga = database.Vagas.Include(v => v.Tecnologia).Include(v => v.Gft).Where(v => v.Disponivel == true && v.Quantidade >= 1).ToList();
            return View(Vaga);
        }

        [Authorize(Policy = "TemCargo")]
        public IActionResult CadastrarVaga(){
            ViewBag.Tecnologia = database.Tecnologias.ToList();
            ViewBag.Gft = database.Gfts.ToList();
            return View();
        }

          public IActionResult Alocacao(){
            ViewBag.Gft = database.Gfts.ToList();
            ViewBag.FuncionarioTecnologia = database.FuncionarioTecnologias.ToList();
            ViewBag.FuncionarioTecnologia = (from f in database.FuncionarioTecnologias
                                               select f.Tecnologia.NomeTec).Distinct();
            ViewBag.Vaga = (from v in database.Vagas
                               select v.Projeto).Distinct();
            ViewBag.Funcionario = database.Funcionarios.Where(f => f.Alocado == true).ToList();
            ViewBag.Vaga = database.Vagas.Where(v => v.Disponivel == true && v.Quantidade >= 1).ToList();
            var Alocacao = database.Alocacoes.Include(a => a.Funcionario).Include(a => a.Vaga).Include(f => f.FuncionarioTecnologia).ToList();
            return View(Alocacao);
        }

        [Authorize(Policy = "TemCargo")]
         public IActionResult Alocar(){
            ViewBag.Vaga = database.Vagas.Where(v => v.Disponivel == true).ToList();
            ViewBag.Funcionario = database.Funcionarios.Where(f => f.Alocado == false).ToList();
            
            return View();}

        [Authorize(Policy = "TemCargo")]
        public IActionResult Historico (){
            ViewBag.Vaga = (from v in database.Vagas select v.Projeto).Distinct();
            ViewBag.Funcionario = database.Funcionarios.Where(f => f.Alocado == false).ToList();
            ViewBag.Vaga = database.Vagas.Where(v => v.Disponivel == true && v.Quantidade >= 1).ToList();
            var Alocacao = database.Alocacoes.Include(a => a.Funcionario).Include(a => a.Vaga).ToList();
            return View (Alocacao);
        }
    
        [Authorize(Policy = "TemCargo")]
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

        [Authorize(Policy = "TemCargo")]
        public IActionResult EditarTecnologia (int id){
            var tecnologia = database.Tecnologias.First(tec => tec.Id == id);
            TecnologiaDTO tecnologiaView = new TecnologiaDTO();
            tecnologiaView.Id = tecnologia.Id;
            tecnologiaView.NomeTec = tecnologia.NomeTec;
            tecnologiaView.TipoTec = tecnologia.TipoTec;
            
            return View (tecnologiaView);
        }

        [Authorize(Policy = "TemCargo")]

            public IActionResult EditarFuncionario (int id){
            ViewBag.Tecnologia = database.Tecnologias.ToList();
            ViewBag.Gft = database.Gfts.ToList();
            ViewBag.FuncionarioTecnologia = database.FuncionarioTecnologias.ToList();

            var funcionario = database.Funcionarios.Include(f => f.Gft).First(f => f.Id == id);
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

                        
            var FuncionarioTec = database.FuncionarioTecnologias.Where(func => func.Funcionario.Id == funcionario.Id).ToList();
            database.RemoveRange (FuncionarioTec);
            database.SaveChanges(); 
           
            return View (funcionarioView);
            }
            [Authorize(Policy = "TemCargo")]
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

        [Authorize(Policy = "TemCargo")]
            public IActionResult EditarAlocacao (int id){
            var alocar = database.Alocacoes.Include(v => v.Vaga).Include(f => f.Funcionario).First(a => a.Id == id);
            AlocacaoDTO alocarView = new AlocacaoDTO();
            alocarView.Id = alocar.Id;
            alocarView.InicioAlocacao = alocar.InicioAlocacao;
            alocarView.FuncionarioId = alocar.Funcionario.Id;
            alocarView.VagaId = alocar.Vaga.Id;

               var funcionario = database.Funcionarios.First(func => func.Id == alocar.Funcionario.Id);
                funcionario.Alocado = false;
                database.SaveChanges();   

                var vaga = database.Vagas.First(vag => vag.Id == alocar.Vaga.Id);
                vaga.Quantidade = vaga.Quantidade + 1; 
                vaga.Disponivel = true;
                database.SaveChanges();   

            ViewBag.Funcionario = database.Funcionarios.ToList();
            ViewBag.Vaga = database.Vagas.ToList();
            return View (alocarView);
        }

    }
}