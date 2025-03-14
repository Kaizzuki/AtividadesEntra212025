namespace Encapsulamento
{
    public class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente cc = new ContaCorrente("João Silva", 123, 1000);
            cc.Depositar(500);
            cc.Sacar(200);
            cc.ExibirSaldo();

            ContaPoupanca cp = new ContaPoupanca("Maria Souza", 456, 2000);
            cp.Depositar(1000);
            cp.Sacar(500);
            cp.ExibirSaldo();

        }
    }
}