namespace ConsultorioDentista
{
    public class Colaborador : Pessoas
    {
        public string HorarioEntrada { get; set; }
        public string Intervalo { get; set; }
        public string FimDoIntervalo { get; set; }
        public string HorarioSaida { get; set; }
        public Colaborador(string nome, string sobrenome, string profissao, 
            string horarioEntrada, string intervalo, string fimDoIntervalo, string horarioSaida)
        {
            Nome = nome;
            SobreNome = sobrenome;
            Profissao = profissao;
            HorarioEntrada = horarioEntrada;
            Intervalo = intervalo;
            FimDoIntervalo = fimDoIntervalo;
            HorarioSaida = horarioEntrada;
        }

    }
}
