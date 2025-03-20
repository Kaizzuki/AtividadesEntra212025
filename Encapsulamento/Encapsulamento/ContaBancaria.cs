using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        //Dados Privados

        private string _titular;
        private int _numeroConta;
        private decimal _saldo;

        //Gets e setters
        public string Titular { 
            get;
            set;
        }
        public int NumeroConta {
            get;
            set;
        }
        public decimal Saldo {
            get;
            set;
        }
        
        public ContaBancaria(string Titular, int NumeroConta, decimal Saldo)//CONSTRUTOR
        {
            this.Titular = Titular;
            this.Saldo = Saldo;
            this.NumeroConta= NumeroConta;
        }

        public virtual decimal Depositar(decimal quantia)
        {
            Saldo += quantia;
            return _saldo;
        }

        public virtual decimal Sacar(decimal saque)
        {
            try
            {
                if (saque < Saldo && saque > 0)
                {
                    return Saldo -= saque;
                }
                else
                {
                    Console.WriteLine("Não é possivel sacar valor");
                    throw new Exception("Saldo insuficiente");
                }
            }   catch (FormatException) 
                { Console.WriteLine("Formato inválido"); }
                catch (Exception ex) 
                { Console.WriteLine(ex); }

            return Saldo;
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("{0} - R${1}",Titular,Saldo);
        }

        public void ExibirDados()
        {
            
            Console.WriteLine("Titular: {0}", Titular);
            Console.WriteLine("Numero da Conta: {0}", NumeroConta);
            Console.WriteLine("Saldo atual: {0}", Saldo);
            
        }

    }
}
