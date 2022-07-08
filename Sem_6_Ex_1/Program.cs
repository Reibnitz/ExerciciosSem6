using Sem_6_Ex_1;

List<Conta> listaDeContas = new List<Conta>
{
    new Conta(111, 1000, 200, true),
    new Conta(222, 1500, 100, true),
    new Conta(333, 100, 200, true),
    new Conta(444, 500, 200, false),
    new Conta(555, 5000, 1000, true)
};

while (true)
{
    MensagensConsole.Iniciar();

    int numeroConta = MensagensConsole.SelecionarConta(listaDeContas);
    Conta contaSelecionada = listaDeContas[numeroConta];

    int numeroOperacao = MensagensConsole.SelecionarOperacao();
    decimal valorOperacao = MensagensConsole.SelecionarValor(numeroOperacao);

    try
    {
        switch (numeroOperacao)
        {
            case 1:
                contaSelecionada.MostrarSaldo();
                break;
            case 2:
                contaSelecionada.Sacar(valorOperacao);
                break;
            case 3:
                contaSelecionada.Depositar(valorOperacao);
                break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}