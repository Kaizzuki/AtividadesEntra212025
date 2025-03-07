
namespace ProgamaçãoOrientadaAObjeto
{
    internal class Program
    {
        static void AdicionarProdutoPedido(Pedido pedido, List<Produto> cardapio)
        {
            //Controle
            string escolhido;
            bool escolhendo = true;

            while (escolhendo)
            {
                bool encontrado = false;
                Console.WriteLine("");
                Console.WriteLine("Digite:");
                do
                {
                    escolhido = Console.ReadLine();
                } while (string.IsNullOrEmpty(escolhido));

                foreach (Produto produto in cardapio)
                {
                    if (escolhido.Equals(produto.NomeProduto, StringComparison.OrdinalIgnoreCase))
                    {
                        pedido.Produtos.Add(produto);
                        encontrado = true;
                    }
                }
                
                if (!encontrado)
                    Console.WriteLine("Produto não encontrado ou invalido.");

                Console.WriteLine("Deseja continuar a escolher? Sim ou não.");

                string res;
                do
                {
                    res = Console.ReadLine();
                } while (string.IsNullOrEmpty(res));

                if (res.Equals("Não", StringComparison.OrdinalIgnoreCase))
                {
                    escolhendo = false;
                }

            }
        }

        static Pedido CadastrarPedido(List<Produto> cardapio, int NumPedido)
        {
            Pedido pedidoCadastrado = new Pedido();
            pedidoCadastrado.NumeroPedido = NumPedido;

            Console.WriteLine("");
            Console.WriteLine("Escolha um dos pedidos: ");
            foreach (Produto produto in cardapio)
            {
                Console.WriteLine($"{produto.NomeProduto}: R$ {produto.ValorProduto}");
            }

            AdicionarProdutoPedido(pedidoCadastrado, cardapio);    
            
            return pedidoCadastrado;
        }

        static void AdicionarNovoPedido(List<Pedido> listaPedidos, List<Produto> cardapio)
        {
            bool adicionando = true;
            do
            {
                listaPedidos.Add(CadastrarPedido(cardapio, listaPedidos.Count+1));
                foreach (Pedido pedidos in listaPedidos)
                {
                    Console.WriteLine("");
                    pedidos.ExibirPedido();
                    Console.WriteLine("");
                }

                Console.WriteLine("Deseja continuar adicionando pedidos? Sim ou não.");

                string res;
                do
                {
                    res = Console.ReadLine();
                } while (string.IsNullOrEmpty(res));

                if (res.Equals("Não", StringComparison.OrdinalIgnoreCase))
                {
                    adicionando = false;
                }

            } while (adicionando);
            
        }

        static void Main(string[] args)
        {

            //Produtos
            Produto hambúrguer = new Produto();
            hambúrguer.NomeProduto = "X-Burguer";
            hambúrguer.ValorProduto = 15.00;

            Produto batataFrita = new Produto();
            batataFrita.NomeProduto = "Batata Frita";
            batataFrita.ValorProduto = 8.00;

            Produto refrigerante = new Produto();
            refrigerante.NomeProduto = "Refrigerante";
            refrigerante.ValorProduto = 5.00;

            List<Produto> cardapio = new List<Produto> {hambúrguer, batataFrita, refrigerante};
           
            //Pedido
            List<Pedido> listaPedidos = new List<Pedido>();

            Pedido pedido1 = new Pedido();
            pedido1.NumeroPedido = 1;
            pedido1.Produtos.Add(hambúrguer);
            pedido1.Produtos.Add(batataFrita);

            Pedido pedido2 = new Pedido();
            pedido2.NumeroPedido= 2;
            pedido2.Produtos.Add(refrigerante);

            //Exibindo
            pedido1.ExibirPedido();
            Console.WriteLine("");
            pedido2.ExibirPedido();
            Console.WriteLine("");


            AdicionarNovoPedido(listaPedidos, cardapio);

        }
    }
}