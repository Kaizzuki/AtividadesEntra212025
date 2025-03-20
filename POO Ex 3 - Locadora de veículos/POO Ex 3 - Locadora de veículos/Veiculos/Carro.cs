using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex_3___Locadora_de_veículos.Veiculos
{
    public class Carro : Veiculo
    {
        public Carro(string Modelo, string Marca, int Ano, decimal Aluguel) :
            base(Modelo, Marca, Ano, Aluguel)
        {

        }
        public override decimal CalcularAluguel(int dias)
        {
            return (BaseDiariaAluguel * dias);
        }
    }
}
