using Sem_6_Ex_5;

Console.WriteLine("Exercício 5 - Abstração Agenda de compromissos");
IAgenda agenda = Factory.CriarAgenda();
bool continuar = true;

while (continuar)
{
    try
    {
        MensagensConsole.ListarOperacoes();
        Operacao operacao = MensagensConsole.EscolherOperacao();
        switch (operacao)
        {
            case Operacao.CriarCompromisso:
                MensagensConsole.CriarCompromisso(agenda);
                break;
            case Operacao.MostrarLista:
                agenda.MostrarCompromissos();
                break;
            case Operacao.MostrarCompromissosDoDia:
                agenda.MostrarProximosCompromissosDoDia();
                break;
            default:
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.StackTrace);
    }
}