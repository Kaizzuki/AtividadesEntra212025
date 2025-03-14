using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaPoupanca : ContaBancaria
    {
        private double _bonusDeposito = 0.005;
        public ContaPoupanca(string Titular, int NumeroConta, decimal Saldo) 
                :base(Titular, NumeroConta, Saldo)
        { 
        
        }

        public override decimal Depositar(decimal quantia)
        {
            decimal bonus = quantia * (decimal)_bonusDeposito;
            
            Saldo = Saldo + quantia + Math.Round(bonus, 2);
            return Saldo;
        }

    }
}
