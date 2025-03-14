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
        
        public override decimal Sacar(decimal saque)
        {
            try
            {
                if (saque < Saldo && saque > 0)
                {
                    Saldo = Saldo - saque - _taxaSaque; ;
                    return Saldo;
                }
                else
                {
                    Console.WriteLine("Não é possivel sacar valor");
                    throw new Exception("Saldo insuficiente");
                }
            }
            catch (FormatException)
            { Console.WriteLine("Formato inválido"); }
            catch (Exception ex)
            { Console.WriteLine(ex); }

            return Saldo;
        }

    }

}
