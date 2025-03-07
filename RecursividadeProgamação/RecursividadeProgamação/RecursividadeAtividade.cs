namespace RecursividadeProgamação
       
{
    internal class Program
    {
        static void Main(string[] args)//RUN MAIN
        {
            MenuPrincipal();
        }
        //Funções    --------------------------------
        static int LowestP(int divNum)
        {
            if (divNum == 1)
                return 1;

            int p = 2;
            while (!(divNum % p == 0))
            {
                p++;
            }
            return p;

        }

        static int Potencia(int n, int e)
        {
            if (e == 1)
                return n;

            return n * Potencia(n, e - 1);

        }

        static int Somatoria(int i)
        {
            if (i <= 1)
                return i;

            return i + Somatoria(i - 1);
        }

        static int Fibbonaci(int n)
        {
            if (n < 2)
                return 1;

            return Fibbonaci(n - 1) + Fibbonaci(n - 2);
        }

        static int ContagemRegressiva(int num)
        {
            Console.WriteLine(num);
            if (num == 1)
                return 1;

            return ContagemRegressiva(num - 1);
        }

        static int MDC(int a, int b)
        {
            if ((a == 0) || (b == 0))
                return a + b;

            return MDC(b, a % b);
        }

        //Menus      --------------------------------
        static void MenuPrincipal()
        {
            bool ativo = true;
            do
            {

                Console.WriteLine("Escolha uma das atividades");

                Console.WriteLine("1 - Potencia");
                Console.WriteLine("2 - Soma de numeros inteiros");
                Console.WriteLine("3 - Fibonacci");
                Console.WriteLine("4 - Contagem regressiva");
                Console.WriteLine("5 - Máximo divisor comum");
                Console.WriteLine("0 - Sair");

                int opcao = EscolhaInt("Digite sua escolha");

                switch (opcao)
                {
                    case 0:
                        ativo = false;
                        Console.WriteLine("Até a proxima!");
                        break;
                    case 1:
                        Console.Clear();
                        Atividade1();
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Atividade2();
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Atividade3();
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        Atividade4();
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.Clear();
                        Atividade5();
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Escolha invalida");
                        break;
                }
            
            }
            while (ativo);

        }

        

        //Escolhas   --------------------------------
        static int EscolhaInt(string pergunta)
        {
            string numero;
            if (!string.IsNullOrEmpty(pergunta))
            {
                Console.WriteLine(pergunta);
            }

            while (true)
            {
                try
                {
                    numero = Console.ReadLine();

                    if (int.TryParse(numero, out int result))
                    {
                        return Convert.ToInt32(numero);
                    }
                    else
                    {
                        throw new Exception("Valor invalido!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //Atividades --------------------------------

        static void Atividade1()
        {
            int num = EscolhaInt("Digite um numero para ser potencializado");
            int expo = EscolhaInt("Digite o numero que sera expoente");

            Console.WriteLine("{0}^{1} = {2}",num,expo,Potencia(num, expo));
        }

        static void Atividade2()
        {
            int num = EscolhaInt("Digite um valor no qual todos seus antecessores serão somados");

            Console.WriteLine("A soma total até {0} é {1}", num, Somatoria(num));
        }

        static void Atividade3()
        {
            int num = EscolhaInt("Digite o termo que deseja ver da sequencia de fibonacci");

            Console.WriteLine("O termo {0} de fibonacci é {1}", num, Fibbonaci(num - 1));
        }

        static void Atividade4()
        {
            int num = EscolhaInt("Digite um numero que sera o inicio da contagem regressiva");

            Console.WriteLine("Começando!");

            ContagemRegressiva(num);

        }
        static void Atividade5()
        {
            int a = EscolhaInt("Escolha o primeiro valor do calculo MDC");
            int b = EscolhaInt("Escolha o segundo valor do calculo MDC");

            Console.WriteLine("O MDC de {0},{1} é {2}",a,b, MDC(a, b));
        }
    }
}
