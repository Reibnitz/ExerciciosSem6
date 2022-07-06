namespace Sem_6_Ex_3.Interfaces
{
    public interface IAluno
    {
        List<IAvaliacao> Boletim { get; }
        List<IDisciplina> ListaDeDisciplinas { get; }
        string Nome { get; set; }
        int NumeroChamada { get; set; }

        void AdicionarAvaliacao(IAvaliacao avaliacao);
    }
}