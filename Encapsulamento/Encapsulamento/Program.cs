namespace Encapsulamento
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria("Jose", 24, 100.00m);

            conta.Depositar();
            conta.ExibirSaldo();    
        }
    }
}