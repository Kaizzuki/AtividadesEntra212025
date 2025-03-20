using POO_Ex_3___Locadora_de_veículos.Veiculos;

namespace POO_Ex_3___Locadora_de_veículos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carrinho = new Carro("Celta", "Chevrolet", 2009, 100.00m);
            Moto motoca = new Moto("Start", "Honda", 2016, 100.00m);
            Caminhao caminhone = new Caminhao("Constelation", "Volkswagen", 2019, 100.00m);
            
            carrinho.Exibir();
            Console.WriteLine("O aluguel por 5 dias é {0}", carrinho.CalcularAluguel(5));
            Console.WriteLine("---");


            motoca.Exibir();
            Console.WriteLine("O aluguel por 5 dias é {0}", motoca.CalcularAluguel(5));
            Console.WriteLine("---");


            caminhone.Exibir();
            Console.WriteLine("O aluguel por 5 dias é {0}", caminhone.CalcularAluguel(5));
            Console.WriteLine("---");

        }
    }
}