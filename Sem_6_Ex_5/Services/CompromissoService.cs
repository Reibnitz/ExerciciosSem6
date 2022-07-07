using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_5
{
    public class CompromissoService : ICompromissoService
    {
        public ICompromisso CriarCompromisso(string nome, string descricao, DateOnly data, TimeOnly horario, TimeSpan duracao)
        {
            return Factory.CriarCompromisso(nome, descricao, data, horario, duracao);
        }

        public List<ICompromisso> MostrarProximosCompromissosDoDia(List<ICompromisso> compromissos)
        {
            DateTime agora = DateTime.Now;
            DateOnly dataAtual = new(agora.Year, agora.Month, agora.Day);
            TimeOnly horarioAtual = new(agora.Hour, agora.Minute);

            List<ICompromisso> compromissosOrdenados = OrdernarPorHorario(compromissos);

            List<ICompromisso> compromissosDoDia = compromissosOrdenados
                .Where(compromisso => compromisso.Data == dataAtual)
                .ToList();

            List<ICompromisso> proximosCompromissosDoDia = compromissosDoDia
                .Where(compromisso => compromisso.Horario >= horarioAtual)
                .ToList();

            if (compromissosDoDia.Count == 0)
                throw new DiaSemAtividadesException(dataAtual);

            if (proximosCompromissosDoDia.Count == 0)
                throw new DiaSemMaisAtividadesException();

            return proximosCompromissosDoDia;
        }

        public List<ICompromisso> OrdernarPorData(List<ICompromisso> compromissos)
        {
            List<ICompromisso> compromissosOrdenados = compromissos.OrderBy(compromisso => compromisso.DataEHora).ToList();
            return compromissosOrdenados;
        }

        public List<ICompromisso> OrdernarPorHorario(List<ICompromisso> compromissos)
        {
            List<ICompromisso> compromissosOrdenados = compromissos.OrderBy(compromisso => compromisso.Horario).ToList();
            return compromissosOrdenados;
        }
    }
}