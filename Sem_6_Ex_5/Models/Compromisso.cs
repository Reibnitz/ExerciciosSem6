using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_5
{
    public class Compromisso : ICompromisso
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateOnly Data { get; set; }
        public TimeOnly Horario { get; set; }
        public TimeSpan Duracao { get; set; }
        public DateTime DataEHora { get; private set; }

        public Compromisso(string nome, string descricao, DateOnly data, TimeOnly horario, TimeSpan duracao)
        {
            Nome = nome;
            Descricao = descricao;
            Data = data;
            Horario = horario;
            Duracao = duracao;

            DataEHora = new DateTime(data.Year, data.Month, data.Day, horario.Hour, horario.Minute, 0);
        }
    }
}