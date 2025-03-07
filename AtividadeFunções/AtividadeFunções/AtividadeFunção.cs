using System;
using System.Data;
using System.Diagnostics.Tracing;

class Program
{
    public static void Main(string[] args)
    {
        MenuPrincipal();
    }

    //Funções basicas
    static int Escolha(string pergunta)
    {
        Console.WriteLine(pergunta);
        string escolha = Console.ReadLine();

            try
            {
                Convert.ToInt32(escolha);
                return Convert.ToInt32(escolha);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        
    }

    //Funções avançadas
    static void MenuPrincipal()
    {
        bool ativo = true;

        do
        {
            Console.WriteLine("__________Menu de atividades__________");
            Console.WriteLine("Digite a atividade que deseja escolher: ");
            Console.WriteLine("1 - Somar dois numeros");
            Console.WriteLine("2 - Calcular fatorial");
            Console.WriteLine("3 - Verificar se é primo");
            Console.WriteLine("4 - Encontrar maior da lista");
            Console.WriteLine("5 - Inversor de frase");
            Console.WriteLine("6 - Calcular media de lista");
            Console.WriteLine("7 - Verificar um se é palindromo");
            Console.WriteLine("8 - Converter Celsius para Fahrenheit");
            Console.WriteLine("9 - Quantas strings maior que 5");
            Console.WriteLine("10 - Maximo divisor comum");
            Console.WriteLine("11 - Encontrar pares de uma lista");
            Console.WriteLine("12 - Encontrar elementos repetidos de uma lista");
            Console.WriteLine("13 - Atividade inverter a caixa da string");
            Console.WriteLine("14 - Fibonacci com determinado termos");
            Console.WriteLine("15 - Verifica se numero é positivo/negativo/zero");
            Console.WriteLine("16 - Calculadora simples");
            Console.WriteLine("17 - Verificação primo(duplicado)");
            Console.WriteLine("18 - Sequencia fibonacci(duplicado)");
            Console.WriteLine("19 - Contagem de digitos");
            Console.WriteLine("20 - Média de números(Meio duplicado)");
            Console.WriteLine("0 - Sair");

            try
            {
                int opção = Escolha("Selecione uma opção");

                switch (opção)
                {
                    case 1:
                        AtividadeSomar();
                        break;

                    case 2:
                        AtividadeFatorial();
                        break;

                    case 3:
                        AtividadeVerificarPrimo();
                        break;

                    case 4:
                        AtividadeMaiorDaLista();
                        break;

                    case 5:
                        InversorDeFrase();
                        break;

                    case 6:
                        AtividadeCalcularMedia();
                        break;

                    case 7:
                        AtividadeVerificarPalindromo();
                        break;

                    case 8:
                        AtividadeConversorFahrenheit();
                        break;

                    case 9:
                        AtividadeQuantidadeStringMaior5();
                        break;

                    case 10:
                        AtividadeMDC();
                        break;

                    case 11:
                        AtividadeEncontrarPares();
                        break;

                    case 12:
                        AtividadeEncontrarElementoRepetido();
                        break;

                    case 13:
                        AtividadeInverterCaixaLetra();
                        break;

                    case 14:
                        AtividadeFibonacci();
                        break;

                    case 15:
                        AtividadeVerificarPositivoOuNegativo();
                        break;

                    case 16:
                        AtividadeCalculadoraSimples();
                        break;

                    case 17:
                        AtividadeVerificarPrimo();
                        break;

                    case 18:
                        AtividadeFibonacci();
                        break;

                    case 19:
                        AtividadeContarDigitos();
                        break;

                    case 20:
                        AtividadeMedia3();
                        break;

                    case 0:
                        Console.WriteLine("Saindo... Tenha um bom dia");
                        ativo = false;
                        break;

                    default:
                        throw new Exception("Opção invalida");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } while (ativo);
    }

        //Principal das atividades
        static void AtividadeSomar()
        {
            int n1 = Escolha("Digite um numero");

            int n2 = Escolha("Digite o segundo numero");

            Console.Write("\nO resultado é ");
            Console.WriteLine(Somar(n1, n2));
        }

        static void AtividadeFatorial()
        {
            int n1 = Escolha("Digite um numero para fatoriar");

            Console.Write("O fatorial de {0} é ", n1);
            Console.WriteLine(Fatoriar(n1));
        }

        static void AtividadeVerificarPrimo()
        {
            int num = Escolha("Digite o numero inteiro que deseja verificar");
            string resposta = (VerificarPrimo(num)) ? "O numero é primo" : "O numero não é primo";
            Console.WriteLine(resposta);
        }

        static void AtividadeMaiorDaLista()
        {
            Console.WriteLine("Digite 'sair' para parar de adicionar numeros");
            string escolha = "";
            List<int> listaNumeros = new List<int>();
            while (escolha != "sair")
            {
                Console.WriteLine("Escreva um numero");
                escolha = Console.ReadLine();

                try
                {
                    if (escolha.ToLower() != "sair")
                    {
                        listaNumeros.Add(Convert.ToInt32(escolha));
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

            }

            Console.WriteLine($"O maior numero é {EncontrarMaior(listaNumeros)}"); 

        }

        static void InversorDeFrase()
        {
    
            Console.WriteLine("Insira uma frase/palavra que deseja invertir");
            string frase = Console.ReadLine();

            Console.WriteLine(InverterFrase(frase));
        }

        static void AtividadeCalcularMedia()
        {
            string escolha = "";
            List<int> listaNota = new List<int>(); 

            while (escolha != "sair")
            {
                Console.WriteLine("Digite a nota para acrescentar a lista.");
                escolha = Console.ReadLine();

                try
                {
                    if (escolha.ToLower() != "sair")
                    {
                        int nota = Convert.ToInt32(escolha);

                        listaNota.Add(nota);
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message) ; 
                }
            }
            Console.WriteLine("a media foi: ");
            Console.WriteLine(CalcularMediaLista(listaNota));

        }

        static void AtividadeVerificarPalindromo()
        {
            Console.WriteLine("Digite uma palavra para checar se é um palindromo: ");
            string palindromo = Console.ReadLine();

            string resposta = (VerificarPalidromo(palindromo)) ? "A palavra é um palindromo" : "A palavra não é um palindromo"  ;
            Console.WriteLine(resposta);
        }

        static void AtividadeConversorFahrenheit()
        {
            Console.WriteLine("Digite um valor em celsius");
            float c =  float.Parse(Console.ReadLine());

            Console.WriteLine("O valor de {0} Celsius para Fahrenheit é: ", c);
            Console.WriteLine(ConverterCelsiusFahrenheit(c)); 
        }

        static void AtividadeQuantidadeStringMaior5()
        {
            Console.WriteLine("Digite 1 para sair");
            Console.WriteLine("Insira palavras:");
            List<string> listaString = new List<string>();
            string entrada = "";

            while (entrada != "1")
            {
                entrada = Console.ReadLine();
                listaString.Add(entrada);
            }

            Console.Write("A quantidade de palavras com mais de 5 caracteres são: ");
            Console.WriteLine( QuantidadeDeStringsMaior5(listaString) );
        }

        static void AtividadeMDC()
        {
            int n1 = Escolha("Digite um numero");
            int n2 = Escolha("Digite outro numero");

            Console.WriteLine("O mdc desses numeros é: ");
            Console.WriteLine(EncontrarMaximoDivisorComum(n1, n2));

        }

        static void AtividadeEncontrarPares()
        {
            string escolha = "";
            List<int> listaNumeros = new List<int>();

            while (escolha != "sair")
            {
                Console.WriteLine("Digite a nota para acrescentar a lista.");
                escolha = Console.ReadLine();

                try
                {
                    if (escolha.ToLower() != "sair")
                    {
                        int Num = Convert.ToInt32(escolha);

                        listaNumeros.Add(Num);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Tente novamente.");
                }
            }

            Console.WriteLine("Os pares dessa sequencia são");
            List<int> listaPar = EncontrarPares(listaNumeros);
            foreach (int i in listaPar)
            {
                Console.Write($"{i}, ");
            }

            static void AtividadeQuantasRepeticao()
            {
                List<string> lista = new List<string>();
                string escolha = "";

                Console.WriteLine("Acrescente a lista: ");
                
                while (escolha != "sair")
                {
                    Console.WriteLine("Digite a nota para acrescentar a lista.");
                    escolha = Console.ReadLine();

                    try
                    {
                        if (escolha.ToLower() != "sair")
                        {
                             lista.Add(escolha);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Tente novamente.");
                    }
                }
                Console.WriteLine("Oque deseja saber se repetiu? ");
                string analise = Console.ReadLine();


                Console.WriteLine($"{analise} Foi repetido: ");
                Console.WriteLine(QuantasRepeticoes(lista, analise));
            }
        }

        static void AtividadeEncontrarElementoRepetido()
        {
            Console.WriteLine("Insira na lista os elementos: ");
            string escolha = "";
            List<string> lista = new List<string>();

            while (escolha != "sair")
            {
                escolha = Console.ReadLine();

                try
                {
                    if (escolha.ToLower() != "sair")
                    {
                        lista.Add(escolha);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Tente novamente.");
                }
            }

            Console.WriteLine("Insira o nome do elemento que deseja procurar:");

            string procurado = "";

            try 
            { 
                procurado = Console.ReadLine();
            } catch (Exception ex) { Console.WriteLine("tente novamente"); }

            Console.WriteLine("O elemento {0} aparece {1} vezes na lista", procurado , QuantasRepeticoes(lista, procurado));
        }

        static void AtividadeInverterCaixaLetra()
        {
            Console.WriteLine("Insira uma frase para inverter a caixa");
            string frase = Console.ReadLine();

            Console.WriteLine(InversorLetterCase(frase));
        }

        static void AtividadeFibonacci()
        {

            int quantidade = Escolha("Insira uma quantidade de vezes para o fibonacci");

            Console.WriteLine("gerando... \n________________________________________________");
            FibonacciDeterminado(quantidade);

        }

        static void AtividadeVerificarPositivoOuNegativo()
        {
            int num = Escolha("Digite o numero para verificar");

            Console.WriteLine($"O numero é {VerificadorNumeroPosOuNeg(num)}");
        }

        static void AtividadeCalculadoraSimples()
        {
            Console.WriteLine("------------------ Calculadora simples ------------------");
            Console.WriteLine("Digite um valor, e então escolha a operação que deseja performar.");
            Console.WriteLine("\nOperações disponiveis: '+' '-' '*' '/'  ");

            string valor1 = "";
            int num1 = 0,
                num2 = 0;
      
            while (valor1 != "sair")
            { 
                valor1 = Console.ReadLine();
                valor1 = valor1.ToLower();
                
                try
                {
                    switch (valor1)
                    {
                        case "+":
                            num2 = Convert.ToInt32(Console.ReadLine());
                            num1 = Somar(num1, num2);
                            Console.WriteLine(num1);
                            break;

                        case "-":
                            num2 = Convert.ToInt32(Console.ReadLine());
                            num1 = Sub(num1, num2);
                            Console.WriteLine(num1);
                            break;

                        case "*":
                            num2 = Convert.ToInt32(Console.ReadLine());
                            num1 = Mult(num1, num2);
                            Console.WriteLine(num1);
                            break;

                        case "/":
                            num2 = Convert.ToInt32(Console.ReadLine());
                            num1 = Div(num1, num2);
                            Console.WriteLine(num1);
                            break;

                        //Caso não seja um operador
                        default:
                            if (!valor1.Any(char.IsAsciiLetter))
                            {
                                num1 = Convert.ToInt32(valor1);
                            }
                            else
                            {
                                throw new Exception("Invalido.");
                            }
                            break;
                    }
                } 
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message); 
                }

            }

        }

        static void AtividadeContarDigitos()
        {
            int num = Escolha("Digite um numero qualquer: ");

            Console.WriteLine("Esse numero possui {0} digitos", ContarDigito(num)); 
        }

        static void AtividadeMedia3()
        {
            Console.WriteLine("Calcule mêdia de três numeros");
            List<int> notas = new List<int>();
            for (int i = 1; i <= 3; i++)
            {
                int nota = Escolha("Digite sua nota: ");
                notas.Add(nota);
            }
            Console.WriteLine("A mêdia foi: {0}", CalcularMediaLista(notas)); 
        }
        //Atividades-----------------------------------------------------------------
        static int Somar(int n1, int n2)
        {
          return n1 + n2;
        }

        static int Fatoriar(int n1)
        {
            int fator = n1;

            for (int i = (n1-1); i >= 1; i--)
            {
                fator = fator * i;
            }
            return fator;
        }

        static bool VerificarPrimo(int n1)
        {
            bool isPrimo = true;

            for (int i = 2; i < (n1-1); i++ )
            {
                if (n1 % i == 0) { isPrimo = false; break;}
            }

            return isPrimo;
        }

        static int EncontrarMaior(List<int> lista)
        {
            int maiorNumero = 0;
           foreach (int n in lista)
            {
                if (n > maiorNumero) maiorNumero = n;
            }     
            return maiorNumero;
        }

        static string InverterFrase(string frase)
        {
            string fraseInver = "";

            for (int i =  frase.Length - 1; i >= 0; i--)
            {
                fraseInver += frase[i];
            }
            return fraseInver;
        }

        static int CalcularMediaLista(List<int> listaNota)
        {
            int media;

            media = listaNota.Sum() / listaNota.Count;
            
            return media;
        }

        static bool VerificarPalidromo(string frase)
        {
            string fraseInvertida = InverterFrase(frase);

            bool verificado = (string.Equals(frase, fraseInvertida, StringComparison.OrdinalIgnoreCase)) ? true : false;

            return verificado;
        }

        static float ConverterCelsiusFahrenheit(float celsius)
        {
            float fahrenheit = (celsius * 1.8f) + 32.0f;

            return fahrenheit;
        }

        static int QuantidadeDeStringsMaior5(List<string> listaString)
        {
            int quant = 0;
            
            foreach (string str in listaString)
            {
                if (str.Length > 4)
                {
                    quant++;
                }
            }

            return quant;
        }

        static int EncontrarMaximoDivisorComum(int n1, int n2)
        {
            int[] primos = { 2, 3, 5, 7, 11,
                             13, 17, 19, 23,
                             29, 31, 37, 41,
                             43, 47, 53, 59,
                             61, 67, 71, 73,
                             79, 83, 89, 97  };

            int iteraçãoPrimo = 0, MDC = 0, totalMDC = 1;

            static bool isDivisivel(int n, int div)
            {
                bool isit = (n % div == 0) ? true : false;
                return isit;
            }

            while ((n1 != 1) && (n2 != 1))
            {

                if (isDivisivel(n1, primos[iteraçãoPrimo]) && (isDivisivel(n2, primos[iteraçãoPrimo])))
                {
                    n1 /= primos[iteraçãoPrimo];
                    n2 /= primos[iteraçãoPrimo];
                    MDC = primos[iteraçãoPrimo];
                    totalMDC *= MDC;
                }
                else if (isDivisivel(n1, primos[iteraçãoPrimo]))
                {
                    n1 /= primos[iteraçãoPrimo];
                }
                else if (isDivisivel(n2, primos[iteraçãoPrimo]))
                {
                    n2 /= primos[iteraçãoPrimo];
                }
                else 
                {
                iteraçãoPrimo++;
                }
            }
            return totalMDC;
        }

        static List<int> EncontrarPares(List<int> listaNumeros)
        {
            List<int> listaPares = new List<int>();
            foreach (int n in listaNumeros)
            {
                if (n % 2 == 0)
                {
                    listaPares.Add(n);
                }
            }

            return listaPares;
        }

        static int QuantasRepeticoes(List<string> lista, string elemento)
        {
            int quant = 0;

            for (int i = 0; i <= lista.Count-1; i++)
            {
                if (elemento.Equals(lista[i]))
                {
                    quant++;
                }
            }
            
            return quant;
        }

        static string InversorLetterCase(string str)
        {
            string resultado = "";

            for (int i = 0; i <= str.Length - 1; i++)
            {
             
                if ( char.IsUpper(str[i]) )
                {
                    resultado += char.ToLower(str[i]);                 } 
                else
                {
                    resultado += char.ToUpper(str[i]);
                }

            }

            return resultado;
        }

        static void FibonacciDeterminado(int quant)
        {
            int termo1 = 0,
                termo2 = 1,
                proxTermo; //Soma dos termo 1 + 2

            for (int i = 1; i <= quant; i++)
            {
                Console.Write($"{termo1} ");

                proxTermo = termo1 + termo2;
                termo1 = termo2;
                termo2 = proxTermo;
            }
            Console.WriteLine("\n________________________________________________");
        }

        static string VerificadorNumeroPosOuNeg(int numero)
        {
            if (numero > 0)
            { return "Positivo"; }
            else if (numero < 0)
            { return "Negativo"; }
            else
            { return "Zero"; }

        }

        //Calculadora
        static int Div(int num1, int num2)
        {
            return (num1 / num2);
        }
        static int Mult(int num1, int num2)
        {
            return (num1 * num2);
        }
        static int Sub(int num1, int num2)
        {
            return (num1 - num2);
        }

    

    
    static int ContarDigito(int valor)
    {
        int digito = 0;
        foreach (char c in Convert.ToString(valor))
        {
            digito++;
        }

        return digito;
    }
}