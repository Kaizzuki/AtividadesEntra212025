using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex_3___Locadora_de_veículos.Veiculos
{
    public class Caminhao : Veiculo
    {
        private double _acrescimo = 0.20; //20%
        public Caminhao(string Modelo, string Marca, int Ano, decimal Aluguel) :
            base(Modelo, Marca, Ano, Aluguel) 
        { 

        }

        public override decimal CalcularAluguel(int dias)
        {
            return (BaseDiariaAluguel * dias) + (BaseDiariaAluguel * (decimal)_acrescimo);
        }
    }
}
