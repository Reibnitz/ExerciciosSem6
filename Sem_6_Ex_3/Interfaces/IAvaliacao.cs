namespace Sem_6_Ex_3.Interfaces
{
    public interface IAvaliacao
    {
        IDisciplina Disciplina { get; set; }
        double Nota { get; set; }
        int NumeroAvaliacao { get; set; }
    }
}