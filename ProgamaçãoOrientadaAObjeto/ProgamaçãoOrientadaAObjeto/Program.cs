
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

            Console.WriteLine("Faça seu pedido");
            Console.WriteLine("Escolha um dos produtos: ");
            Console.WriteLine("------------");
            foreach (Produto produto in cardapio)
            {
                Console.WriteLine($"{produto.NomeProduto}: R$ {produto.ValorProduto}");
            }
            Console.WriteLine("------------");

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

                Console.WriteLine("Deseja adicionar um novo pedido? Sim ou Não.");

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

            //Adicionar Produtos a lista
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
           
            //Fazer pedido
            List<Pedido> listaPedidos = new List<Pedido>();

            AdicionarNovoPedido(listaPedidos, cardapio);
        }
    }
}