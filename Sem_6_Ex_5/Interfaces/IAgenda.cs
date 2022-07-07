namespace Sem_6_Ex_5
{
    public interface IAgenda
    {
        void CriarCompromisso(string nome, string descricao, DateOnly data, TimeOnly horario, TimeSpan duracao);
        void MostrarCompromissos();
        void MostrarProximosCompromissosDoDia();
    }
}