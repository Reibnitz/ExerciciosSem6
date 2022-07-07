namespace Sem_6_Ex_5
{
    public interface ICompromisso
    {
        string Nome { get; set; }
        string Descricao { get; set; }
        DateOnly Data { get; set; }
        TimeOnly Horario { get; set; }
        TimeSpan Duracao { get; set; }
        DateTime DataEHora { get; }
    }
}