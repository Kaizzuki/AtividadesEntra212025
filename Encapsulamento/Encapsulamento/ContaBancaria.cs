using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class ContaBancaria
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

        public decimal Depositar()
        {
            Console.WriteLine("Insira a quantidade que deseja depositar na sua conta");
            decimal quantia = decimal.Parse(Console.ReadLine());
            Saldo += quantia;

            return _saldo;
        }

        public decimal Sacar()
        {
            return _saldo;
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("R${0}",Saldo);
        }

    }
}
