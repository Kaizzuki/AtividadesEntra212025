using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex_3___Locadora_de_veículos
{
    public class Veiculo : IVeiculo
    {
        //Propriedades
        private string _modelo;
        private string _marca;
        private int _ano;
        private decimal _baseDiariaAluguel;

        //GETS & SETS
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        } 
        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public int Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }
        public decimal BaseDiariaAluguel
        {
            get { return _baseDiariaAluguel; }
            set { _baseDiariaAluguel = value; }
        }

        //Construtor
        public Veiculo(string Modelo, string Marca, int Ano, decimal Aluguel)
        {
            this.Modelo = Modelo;
            this.Marca = Marca;
            this.Ano = Ano;
            this.BaseDiariaAluguel = Aluguel;
        }


        public virtual decimal CalcularAluguel(int dias)
        {
            return BaseDiariaAluguel * dias;
        }

        public void Exibir()
        {
            Console.WriteLine($"Veiculo: {_modelo} | Marca: {_marca} | Ano: {_ano}");
        }
    }
}
