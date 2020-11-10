using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Desafio_MVC.Models;

namespace Desafio_MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {


        public DbSet<Gft> Gfts {get; set;}
        public DbSet<Tecnologia> Tecnologias {get; set;}
        public DbSet<Funcionario> Funcionarios {get; set;}
        public DbSet<Vaga> Vagas {get; set;}
        public DbSet<Alocacao> Alocacoes {get; set;}
        public DbSet<Publicacao> Publicacoes {get; set;}
        public DbSet<FuncionarioTecnologia> FuncionarioTecnologias {get; set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
