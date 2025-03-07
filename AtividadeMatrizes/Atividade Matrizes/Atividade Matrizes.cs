using System.Numerics;

namespace Atividade_Matrizes
{
    internal class Program
    {
        static void Main(string[] args) //MAIN MAIN
        {
            MenuPrincipal();
        }
        //Menu ------------------------------------------------------------------
        static void MenuPrincipal()
        {
            bool ativo = true;
            do
            {
                Console.WriteLine("----- Menu -----");

                Console.WriteLine("Escolha qual atividade executar: ");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Atividade 1");
                Console.WriteLine("2 - Atividade 2");
                Console.WriteLine("3 - Atividade 3");
                Console.WriteLine("4 - Atividade 4");
                Console.WriteLine("5 - Atividade 5");
                Console.WriteLine("6 - Atividade 6");
                Console.WriteLine("7 - Atividade 7");
                Console.WriteLine("8 - Atividade 8");
                Console.WriteLine("9 - Atividade 9");
                Console.WriteLine("10 - Atividade 10");

                try
                {
                    int opcao = Convert.ToInt32(Console.ReadLine());

                    switch (opcao)
                    {
                        case 0:
                            Console.WriteLine("Tenha um otimo dia!");
                            Console.WriteLine("Saindo.....");
                            ativo = false;
                            break;
                        case 1:
                            Console.Clear();
                            Att1();
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.Clear();
                            Att2();
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.Clear();
                            Att3();
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.Clear();
                            Att4();
                            Console.ReadLine();
                            break;
                        case 5:
                            Console.Clear();
                            Att5();
                            Console.ReadLine();
                            break;
                        case 6:
                            Console.Clear();
                            Att6();
                            Console.ReadLine();
                            break;
                        case 7:
                            Console.Clear();
                            Att7();
                            Console.ReadLine();
                            break;
                        case 8:
                            Console.Clear();
                            Att8();
                            Console.ReadLine();
                            break;
                        case 9:
                            Console.Clear();
                            Att9();
                            Console.ReadLine();
                            break;
                        case 10:
                            Console.Clear();
                            Att10();
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Opção invalida");
                            break;

                    }
                }
                catch (Exception ex) 
                { 
                    Console.WriteLine(ex); 
                }

            } while (ativo);
        }


        //Funções ----------------------------------------------------------------

        static void Att1() //Criando, inicializando e mostrando uma matriz ✓
        {

            int[,] matriz ={
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0} ",matriz[i,j]);
                }
                Console.WriteLine("");
            }
        }

        static void Att2() //Soma de todos elementos de uma matriz
        {
            int[,] matriz =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
            int somaTotal = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    somaTotal += matriz[i,j];
                }
            }

            Console.WriteLine("A soma total é {0}", somaTotal);

        }
        
        static void Att3() //Encontrar o maior e menor valor de uma matriz
        {
            int[,] matriz =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 },
            };
            int maiorValor = 0,
                menorValor = matriz[0,0];

            for (int i = 0;i < matriz.GetLength(0); i++) //Percorrendo
            {
                for (int j = 0;j < matriz.GetLength(1); j++)
                {
                    if (matriz[i,j] > maiorValor)
                    {
                        maiorValor = matriz[i, j];
                    }
                    else if (matriz[i, j] < menorValor)
                    {
                        menorValor = matriz[i, j];
                    }
                }
            }

            Console.WriteLine("O maior valor é {0}", maiorValor);
            Console.WriteLine("O menor valor é {0}", menorValor);

        }

        static void Att4() //Apenas exibir os valores diagonais de uma matriz quadrada
        {
            int[,] matriz =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 },
            };
            int indiceDiagonal = 0;

            for (int i = 0; i < matriz.GetLength(0); i++) //Percorrendo
            {
                Console.WriteLine(matriz[i,indiceDiagonal]);
                indiceDiagonal++;
            }
        }
    
        static void Att5() //Transposta de uma matriz 3x3
        {
            //MATRIZ INICIAL---------------------------
            int[,] matriz =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0} ", matriz[i, j]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("-------------");
            // ----------------------------------------
            int[,] matrizTransposta = new int[3, 3]; 

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matrizTransposta[j,i] = matriz[i,j];
                }
            }

            for (int i = 0; i < matrizTransposta.GetLength(0); i++)
            {
                for (int j = 0; j < matrizTransposta.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrizTransposta[i, j]);
                }
                Console.WriteLine("");
            }
            /* 
                 0 1 2
              0 {1,2,3}
              1 {4,5,6}
              2 {7,8,9}
              
                 0 1 2
              0 {1,4,7}
              1 {2,5,8}
              2 {3,6,9}
              
             */







        }

        static void Att6() //Sabendo se uma matriz é matriz identidade
        {
            int[,] matriz =
            {
                {1,0,0 },
                {0,1,0 },
                {0,0,1 },
            };

            bool isIdentidade = true;
            int indiceDiagonal = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (  (matriz[i,j] != 0) && !(matriz[i, j] == matriz[i, indiceDiagonal])  )
                    {
                        isIdentidade = false;
                    } 
                    else if (matriz[i, indiceDiagonal] != 1)
                    {
                        isIdentidade = false;
                    }
                }
                indiceDiagonal++;
            }

            Console.WriteLine(isIdentidade);
        }

        static void Att7() //Multiplicação de matriz
        {
            int[,] matrizUm =
            {
                { 1,5 },
                { 3,2 }
            },
            matrizDois =
            {
                { 4,8 },
                { 7,0 }
            },
            matrizResultado = new int[2, 2];
            /* Tem que dar:
             39 , 8
             26, 24
                  
              
            */
            for (int i = 0; i < matrizUm.GetLength(0); i++)//Linha
            {
                for( int j = 0; j < matrizUm.GetLength(1); j++)//Coluna
                {

                    matrizResultado[i, j] = ( (matrizUm[i, 0] * matrizDois[0, j]) + (matrizUm[i, 1] * matrizDois[1, j]) );

                }

            }
            for (int i = 0; i < matrizResultado.GetLength(0); i++)
            {
                for (int j = 0; j < matrizResultado.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrizResultado[i, j]);
                }
                Console.WriteLine("");
            }

        }

        static void Att8() //Mêdia de valores de uma matriz
        {
            int[,] matriz =
            {
                { 3, 2, 5, 6},
                { 2, 5, 6, 7},
                { 2, 1, 1, 7},
                { 4, 3, 3, 2}
            };
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0} ", matriz[i, j]);
                }
                Console.WriteLine("");
            }
            //------------------
            int somaTotal = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    somaTotal += matriz[i, j];
                }
            }

            Console.WriteLine("A media foi {0}", somaTotal / matriz.Length);

        }

        static void Att9() //Verificação de matriz esparsa
        {
            int[,] matriz =
            {
                { 0, 2, 0, 6},
                { 0, 5, 0, 7},
                { 0, 1, 0, 7},
                { 0, 3, 0, 0}
            };
            int quantZero = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == 0)
                    {
                        quantZero++;
                    }
                }
            }

            if ( quantZero > (matriz.Length - quantZero )) 
            {
                Console.WriteLine("Matriz esparsa");
            }
            else
            {
                Console.WriteLine("Matriz não esparsa");
            }

        }
    
        static void Att10() //Matriz criavel pelo usuario
        {
            Console.WriteLine("Digite a quantidade de linhas: ");
            int linhas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de colunas ");
            int colunas = Convert.ToInt32(Console.ReadLine());
            int valor;

            int[,] matrizVariavel = new int[linhas, colunas];

            for (int i = 0;i < matrizVariavel.GetLength(0); i++)
            {
                for (int j = 0; j < matrizVariavel.GetLength(1); j++)
                {
                    Console.WriteLine("Coluna {0}", j);
                    Console.WriteLine("Digite: ");
                    valor = Convert.ToInt32(Console.ReadLine());
                    matrizVariavel[i, j] = valor;
                }
                Console.WriteLine("linha {0}", i);
            }

            Console.WriteLine("Sua matriz");

            for (int i = 0; i < matrizVariavel.GetLength(0); i++)
            {
                for (int j = 0; j < matrizVariavel.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrizVariavel[i, j]);
                }
                Console.WriteLine("");
            }

        }    
    }
}