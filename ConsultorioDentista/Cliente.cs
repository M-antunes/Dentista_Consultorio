namespace ConsultorioDentista
{
   public class Cliente : Pessoas
    {
        public int IdPaciente { get; set; }
        public int Idade { get; set; }
        public EnumServico UltimoServico { get; set; }

        public Cliente(int idPaciente, string nome, string sobrenome, int idade, long cpf, 
            string profissao, EnumServico ultimoServico)
        {
            IdPaciente = idPaciente;
            Nome = nome; 
            SobreNome = sobrenome;
            Idade = idade;
            Cpf = cpf;
            Profissao = profissao;
            UltimoServico = ultimoServico;
        }
       
    }
}
