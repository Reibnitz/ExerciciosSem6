using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_5
{
    public class Factory
    {
        public static IAgenda CriarAgenda()
        {
            return new Agenda(CriarCompromissoService());
        }

        public static ICompromisso CriarCompromisso(string nome, string descricao, DateOnly data, TimeOnly horario, TimeSpan duracao)
        {
            return new Compromisso(nome, descricao, data, horario, duracao);
        }

        private static ICompromissoService CriarCompromissoService()
        {
            return new CompromissoService();
        }
    }
}
