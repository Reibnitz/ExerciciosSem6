using Sem_6_Ex_3;
using Sem_6_Ex_3.Interfaces;

List<IDisciplina> listaDeDisciplinas = new List<IDisciplina>()
{
    Factory.CriarDisciplina("HTML/CSS", 2),
    Factory.CriarDisciplina("Javascript", 2),
    Factory.CriarDisciplina("C#", 2)
};

List<IAluno> listaDeAlunos = new List<IAluno>()
{
    Factory.CriarAluno("Eduardo", 1, listaDeDisciplinas),
    Factory.CriarAluno("Lucas", 2, listaDeDisciplinas),
    Factory.CriarAluno("Matheus", 3, listaDeDisciplinas),
    Factory.CriarAluno("Paulo Henrique", 4, listaDeDisciplinas)
};

while (true)
{
    try
    {
        MensagensConsole.ListarAlunos(listaDeAlunos);
        int numeroAluno = MensagensConsole.SelecionarAluno(listaDeAlunos);
        IAluno alunoSelecionado = listaDeAlunos[numeroAluno];
        EOperacao operacaoSelecionada = MensagensConsole.SelecionarOpcao();

        switch (operacaoSelecionada)
        {
            case EOperacao.ListarBoletim:
                MensagensConsole.ListarBoletim(alunoSelecionado);
                break;
            case EOperacao.ListarDisciplinas:
                MensagensConsole.ListarDisciplinas(alunoSelecionado);
                break;
            case EOperacao.InserirAvaliacao:
                IDisciplina disciplina = MensagensConsole.SelecionarDisciplina(alunoSelecionado);
                int numeroAvaliacao = MensagensConsole.SelecionarAvaliacao(disciplina);
                double nota = MensagensConsole.SelecionarNota();

                IAvaliacao avaliacao = Factory.CriarAvaliacao(disciplina, numeroAvaliacao, nota);
                alunoSelecionado.AdicionarAvaliacao(avaliacao);
                break;
            default:
                break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}