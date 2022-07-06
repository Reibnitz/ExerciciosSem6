using Sem_6_Ex_3;
using Sem_6_Ex_3.Interfaces;

while (true)
{
    List<IDisciplina> listaDeDisciplinas = new List<IDisciplina>()
    {
        Factory.CriarDisciplina("HTML/CSS", 2),
        Factory.CriarDisciplina("Javascript", 2),
        Factory.CriarDisciplina("C#", 2)
    };

    IAluno eduardo = Factory.CriarAluno("Eduardo", 1, listaDeDisciplinas);
    IAluno lucas = Factory.CriarAluno("Lucas", 2, listaDeDisciplinas);
    IAluno matheus = Factory.CriarAluno("Matheus", 3, listaDeDisciplinas);
    IAluno paulo = Factory.CriarAluno("Paulo Henrique", 4, listaDeDisciplinas);

    List<IAluno> listaDeAlunos = new List<IAluno>()
    {
        eduardo, lucas, matheus, paulo
    };

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
            IAvaliacao avaliacao = MensagensConsole.CriarAvaliacao(alunoSelecionado);
            alunoSelecionado.AdicionarAvaliacao(avaliacao);
            break;
        default:
            break;
    }
}