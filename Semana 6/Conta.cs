using Sem_6_Ex_1.Exceptions;

namespace Sem_6_Ex_1
{
    public class Conta
    {
        public int Numero { get; private set; }
        public decimal Saldo { get; private set; }
        public decimal LimiteDeSaque { get; private set; }
        public bool EhOperacional { get; private set; }

        public Conta(int numero, decimal saldo, decimal limiteDeSaque, bool ehOperacional)
        {
            Numero = numero;
            Saldo = saldo;
            LimiteDeSaque = limiteDeSaque;
            EhOperacional = ehOperacional;
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"Saldo disponível: R$ {Saldo}");
        }
        
        public void Sacar(decimal valor)
        {
            VerificarOperacionalidade();

            if (valor > Saldo)
                throw new SaldoInsuficienteException(Numero);

            if (valor >= LimiteDeSaque)
                throw new LimiteInsuficienteException(Numero);

            if (valor <= 0 )
                throw new ValorInvalidoException();

            Saldo -= valor;
            MostrarSaldo();
        }
        
        public void Depositar(decimal valor)
        {
            VerificarOperacionalidade();
            if (valor < 0) throw new ValorInvalidoException();

            Saldo += valor;
            MostrarSaldo();
        }

        private bool VerificarOperacionalidade()
        {
            if (!EhOperacional) throw new ContaNaoOperacionalException(Numero);

            return EhOperacional;
        }
    }
}
