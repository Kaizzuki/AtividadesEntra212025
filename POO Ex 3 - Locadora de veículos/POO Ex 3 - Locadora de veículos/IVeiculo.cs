using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex_3___Locadora_de_veículos
{
    internal interface IVeiculo
    {
        public decimal CalcularAluguel(int dias);
        public void Exibir();
    }
}
