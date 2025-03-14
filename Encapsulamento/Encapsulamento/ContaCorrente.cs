using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaCorrente : ContaBancaria
    {
        private decimal _taxaSaque = 5.00m; 

        public ContaCorrente(string Titular, int NumeroConta, decimal Saldo) :
            base(Titular, NumeroConta, Saldo)
        
        {

        }
        

    }

}
