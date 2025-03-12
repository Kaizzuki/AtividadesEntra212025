
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

        static Produto CriarNovoProduto()
        {
            string nomeProduto;
            decimal valorProduto;

            //Nome
            Console.WriteLine("Digite o nome do novo produto: ");
            do
            {
                nomeProduto = Console.ReadLine();
            } while (string.IsNullOrEmpty(nomeProduto));

            //Valor
            Console.WriteLine("Digite o valor do novo produto: ");
            do
            {
                valorProduto = decimal.Parse(Console.ReadLine());
            } while (string.IsNullOrEmpty(nomeProduto));

            Produto produtoGerado = new Produto();
            produtoGerado.NomeProduto = nomeProduto;
            produtoGerado.ValorProduto = valorProduto;

            return produtoGerado;
        }

        static void ModificarProduto(List<Produto> cardapio)
        {
            Console.WriteLine("Produtos ------------------");
            foreach (Produto produto in cardapio)
            {
                Console.WriteLine($"{produto.NomeProduto}:  R${produto.ValorProduto}");
            }
            Console.WriteLine("---------------------------");

            Console.WriteLine("Oque deseja fazer?");
            Console.WriteLine("1 - Modificar nome");
            Console.WriteLine("2 - Modificar valor");
            Console.WriteLine("3 - Remover");

            string opcao = Console.ReadLine();
            string procurado;
            bool encontrado;

            switch (opcao)
            {
                case "1":
                    try
                    {
                        Console.WriteLine("Qual produto deseja modificar?");
                        procurado = Console.ReadLine();
                        encontrado = false;
                        foreach (Produto produto in cardapio)
                        {
                            if (procurado.Equals(produto.NomeProduto, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Insira o novo nome:");
                                produto.NomeProduto = Console.ReadLine();
                                encontrado = true;
                            }
                        }
                        if (encontrado == false)
                        {
                            Console.WriteLine("Produto não encontrado");
                        }
                    }
                    catch (Exception ex) 
                    {
                        Console.WriteLine(ex.Message); 
                    }
                    break;

                case "2":
                    try
                    {
                        Console.WriteLine("Qual produto deseja modificar?");
                        procurado = Console.ReadLine();
                        encontrado = false;
                        foreach (Produto produto in cardapio)
                        {
                            if (procurado.Equals(produto.NomeProduto, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Insira o novo valor:");
                                produto.ValorProduto = decimal.Parse(Console.ReadLine());
                                encontrado = true;
                            }
                        }
                        if (encontrado == false)
                        {
                            Console.WriteLine("Produto não encontrado");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                break;

                case "3":
                    try { 
                    Console.WriteLine("Qual produto deseja remover?");
                    procurado = Console.ReadLine();
                    encontrado = false;
                    foreach (Produto produto in cardapio)
                    {
                        if (procurado.Equals(produto.NomeProduto, StringComparison.OrdinalIgnoreCase))
                        {
                           cardapio.Remove(produto);
                        }
                    }
                    if (encontrado == false)
                    {
                        Console.WriteLine("Produto não encontrado");
                    }
            }
                    catch (Exception ex)
                    {
                Console.WriteLine(ex.Message);
            }

            break;

                default:
                    Console.WriteLine("Inválido");
                    break;
            }
        }

        static void Main(string[] args)
        {
            //Adicionar Produtos a lista
            //PREPARANDO SISTEMA
            Produto hambúrguer = new Produto();
            hambúrguer.NomeProduto = "X-Burguer";
            hambúrguer.ValorProduto = 15.00m;

            Produto batataFrita = new Produto();
            batataFrita.NomeProduto = "Batata Frita";
            batataFrita.ValorProduto = 8.00m;

            Produto refrigerante = new Produto();
            refrigerante.NomeProduto = "Refrigerante";
            refrigerante.ValorProduto = 5.00m;

            //Criando listas
            List<Produto> cardapio = new List<Produto> { hambúrguer, batataFrita, refrigerante };
            List<Pedido> listaPedidos = new List<Pedido>();

            //INTERFACE

            bool ativo = true;
            do
            {
                Console.WriteLine("--------- Bem vindo ---------");
                Console.WriteLine("Escolha uma das opções");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1 - Criar novo produto");
                Console.WriteLine("2 - Modificar produto");
                Console.WriteLine("3 - Ver cardapio");
                Console.WriteLine("4 - Criar novo pedido");
                Console.WriteLine("5 - Ver pedidos");
                Console.WriteLine("");
                Console.WriteLine("0 - Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "0":
                        Console.WriteLine("Até!");
                        ativo = false; 
                        break;

                    case "1":
                        Console.Clear();
                        cardapio.Add(CriarNovoProduto());
                        break;

                    case "2":
                        Console.Clear();
                        ModificarProduto(cardapio);
                        break;

                    case "3":
                        Console.Clear();
                        foreach (Produto produto in cardapio)
                        {
                            Console.WriteLine($"{produto.NomeProduto}:  R${produto.ValorProduto}");
                        }
                        break;

                    case "4":
                        Console.Clear();
                        AdicionarNovoPedido(listaPedidos, cardapio);
                        break;

                    case "5":
                        Console.Clear();
                        
                        if (listaPedidos.Count <= 0)
                        {
                            Console.WriteLine("Nenhum pedido feito!");
                        }
                        else
                        { 
                            foreach (Pedido pedidos in listaPedidos)
                            {
                                Console.WriteLine("");
                                pedidos.ExibirPedido();
                                Console.WriteLine("");
                            }
                        }

                        break;
                }
            } while (ativo);
        }
    }
}