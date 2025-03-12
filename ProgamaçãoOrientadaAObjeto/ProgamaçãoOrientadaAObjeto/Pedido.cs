using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgamaçãoOrientadaAObjeto
{
    internal class Pedido
    {
        //Propriedades

        public int NumeroPedido;
        public List<Produto> Produtos = new List<Produto>();

        //Metodos
        public decimal TotalPedido()
        {
            decimal Total = 0.00m;
            foreach (Produto produto in Produtos)
            {
                Total += produto.ValorProduto;
            }
            return Total;
        }

        public void ExibirPedido()
        {
            Console.WriteLine("Pedido #{0}", NumeroPedido);
            Console.WriteLine("Itens: ");
            foreach (Produto produto in Produtos)
            {
                Console.WriteLine("- {0}: R${1}",produto.NomeProduto, produto.ValorProduto);
            }
            Console.WriteLine("Total: R${0}",TotalPedido());
        }
    }
}
