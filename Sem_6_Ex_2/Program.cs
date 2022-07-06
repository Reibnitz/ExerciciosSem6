using Sem_6_Ex_2;

while (true)
{
    try
    {
        ECalculadora operacaoEscolhida = (ECalculadora)MensagensConsole.EscolherOperacao();
        double valor1 = MensagensConsole.DefinirValor();
        double valor2 = MensagensConsole.DefinirValor();

        double resultado;
        switch (operacaoEscolhida)
        {
            case ECalculadora.Soma:
                resultado = Calculadora.Somar(valor1, valor2);
                break;
            case ECalculadora.Subtracao:
                resultado = Calculadora.Subtrair(valor1, valor2);
                break;
            case ECalculadora.Multiplicacao:
                resultado = Calculadora.Multiplicar(valor1, valor2);
                break;
            case ECalculadora.Divisao:
                resultado = Calculadora.Dividir(valor1, valor2);
                break;
            default:
                resultado = 0;
                break;
        }

        MensagensConsole.ExibirResultado(resultado);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message, e.InnerException);
    }
}