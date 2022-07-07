namespace Sem_6_Ex_5
{
    public interface ICompromissoService
    {
        ICompromisso CriarCompromisso(string nome, string descricao, DateOnly data, TimeOnly horario, TimeSpan duracao);
        List<ICompromisso> MostrarProximosCompromissosDoDia(List<ICompromisso> compromissos);
        List<ICompromisso> OrdernarPorData(List<ICompromisso> compromissos);
        List<ICompromisso> OrdernarPorHorario(List<ICompromisso> compromissos);
    }
}