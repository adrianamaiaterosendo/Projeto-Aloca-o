namespace Desafio_MVC.Models
{
    public class FuncionarioTecnologia
    {
        public int Id {get; set;}
        
        public Funcionario Funcionario {get; set;}

        public Tecnologia Tecnologia {get; set;}
    }
}