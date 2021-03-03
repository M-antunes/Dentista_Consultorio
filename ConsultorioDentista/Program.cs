using System;

namespace ConsultorioDentista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo à Clinica Dentária Dente Feliz!");

            //Lista de clientes.
            Cliente cliente1 = new Cliente(00001, "Juarez", "Gonzales", 23, 05834523682, 
                "Bar Tender", EnumServico.ManutencaoAparelho);
            Cliente cliente2 = new Cliente(00002, "Vinicius", "Silva", 32, 12345678923, 
                "Gari", EnumServico.Limpeza);
            Cliente cliente3 = new Cliente(00003, "Maria", "Dos Santos", 28, 09876543245,
                "Secretária", EnumServico.Consulta);
            Cliente cliente4 = new Cliente(00004, "Márcia", "Assunção", 18, 09812378945,
                "Atleta", EnumServico.ExameComplexo);
            Cliente cliente5 = new Cliente(00005, "Eliza", "Santos", 29, 34567865465, 
                "Frentista", EnumServico.Limpeza);
            Cliente cliente6 = new Cliente(00006, "Arthur", "Lima", 22, 23454367834, 
                "YouTuber", EnumServico.Limpeza);
            Cliente cliente7 = new Cliente(00007, "Jandira", "Clemente", 66, 23454365834, 
                "Aposentada", EnumServico.ImplanteDentario);
            Cliente cliente8 = new Cliente(00008, "Humberto", "Campos", 43, 54378954734,
                "Arquiteto", EnumServico.ProteseDentaria);
            Cliente cliente9 = new Cliente(00009, "Aline", "Ribeiro", 27, 34356745623, 
                "Médica", EnumServico.ExtracaoDeDente);
            Cliente cliente10 = new Cliente(00010, "Thiago", "Paulino", 35, 34589056738, 
                "Contador", EnumServico.Limpeza);

            //Aqui são os colaboradores (Secretárias atendentes)
            Colaborador atendete1 = new Colaborador("Vania", "Duval", "Secretária",
               "07:00", "11:00", "12:00", "14:00");
            Colaborador atendete2 = new Colaborador("Joana", "Pátria", "Secretária",
               "07:00", "11:00", "12:00", "14:00");
            Colaborador atendete3 = new Colaborador("Sônia", "Blade", "Secretária", 
                "12:00", "17:30", "18:30", "20:00");
            Colaborador atendete4 = new Colaborador("Édna", "Valverde", "Secretária",
               "12:00", "17:30", "18:30", "20:00");

            //Aqui estão os dentistas.
            Colaborador dentista1 = new Colaborador("Gustavo", "Massano", "Dentista",
              "07:00", "11:00", "12:00", "14:00");
            Colaborador dentista2 = new Colaborador("Júlia", "Jamelão", "Dentista",
               "12:00", "17:30", "18:30", "20:00");

            //Aqui estão os assistentes.
            Colaborador assistente1 = new Colaborador("Diana", "Rimbola", "Assistente",
              "07:00", "11:00", "12:00", "14:00");
            Colaborador assistente2 = new Colaborador("Patrícia", "Camelion", "Assistente",
               "12:00", "17:30", "18:30", "20:00");



        }
    }
}
