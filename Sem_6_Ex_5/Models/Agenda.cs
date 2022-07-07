using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_5
{
    public class Agenda
    {
        private CompromissoService _compromissoService;
        private List<ICompromisso> Compromissos { get; set; } = new List<ICompromisso>();

        public Agenda()
        {
            _compromissoService = new CompromissoService();
        }

        public void CriarCompromisso(string nome, string descricao, DateOnly data, TimeOnly horario, TimeSpan duracao)
        {
            ICompromisso compromissoCriado = _compromissoService.CriarCompromisso(nome, descricao, data, horario, duracao);

            Compromissos.Add(compromissoCriado);
        }

        public void MostrarCompromissos()
        {
            List<ICompromisso> compromissosOrdenados = _compromissoService.OrdernarPorData(Compromissos);

            Console.WriteLine("\n----- Lista de compromissos -----");

            DateOnly data = new(); // Default: 01/01/0001
            foreach (var compromisso in compromissosOrdenados)
            {
                if (compromisso.Data > data)
                {
                    Console.WriteLine($"\n----- {compromisso.Data} -----");
                    data = compromisso.Data;
                }
                Console.WriteLine($"{compromisso.Horario} - {compromisso.Nome}, duração: {compromisso.Duracao}");
            }
            Console.WriteLine("");
        }

        public void MostrarProximosCompromissosDoDia()
        {
            Console.WriteLine("\n----- Lista de compromissos -----");

            List<ICompromisso> proximosCompromissosDoDia = _compromissoService.MostrarProximosCompromissosDoDia(Compromissos);
            int index = 1;
            foreach (var compromisso in proximosCompromissosDoDia)
            {
                Console.WriteLine($"{index}- {compromisso.Nome} - Horário: {compromisso.Horario}, Duração: {compromisso.Duracao}");
            }
            Console.WriteLine("");
        }
    }
}