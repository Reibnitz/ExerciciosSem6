﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_1.Exceptions
{
    public class ContaNaoOperacionalException : Exception
    {
        private const string Mensagem = "A conta {0} não está em estado operacional";

        public ContaNaoOperacionalException(int numeroConta) : base(string.Format(Mensagem, numeroConta))
        {

        }
    }
}
