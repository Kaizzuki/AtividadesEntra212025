using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Operacao
    {

        public List<ContaCorrente> contasCorrentes = new List<ContaCorrente>();
        public List<ContaPoupanca> contasPoupanca = new List<ContaPoupanca>();

        public void MenuPrincipal()
        {
            bool ativo = true;
            while (ativo) {
                
                Console.WriteLine("------ Sistema bancario ------");
                Console.WriteLine("Escolha o que quer fazer:");
                Console.WriteLine("1 - Criar conta");
                Console.WriteLine("2 - Ver contas");
                Console.WriteLine("3 - Movimentar conta");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CriarContaEscolha();
                        break;

                    case "2":
                        VisualizarContas();
                        break;

                    case "3":
                        EscolherConta();
                        break;
                }
            }
        }
        public void CriarContaEscolha()
        {
            Console.Clear();
            Console.WriteLine("Qual tipo de conta deseja criar?");

            Console.WriteLine("1 - Conta Poupança");
            Console.WriteLine("2 - Conta Corrente");

            object opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    CriarContaPoupanca();
                    break;

                case "2":
                    CriarContaCorrente();
                    break;

            }

        }
        public void CriarContaPoupanca()
        {
            Console.Clear();
            Console.WriteLine("Qual o nome do titular?");
            string Titular = Console.ReadLine();

            Console.WriteLine("Já possui saldo? sim ou não");
            decimal saldo = 0.00m;

            string escolha;
            do
            {
                escolha = Console.ReadLine();
            } while (string.IsNullOrEmpty(escolha));

            if (escolha.Equals("Sim", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Digite o saldo");
                saldo = decimal.Parse(Console.ReadLine());
            }

            ContaPoupanca cp = new ContaPoupanca(Titular, contasPoupanca.Count + 1, saldo);
            contasPoupanca.Add(cp);
        }
        public void CriarContaCorrente()
        {
            Console.Clear();
            Console.WriteLine("Qual o nome do titular?");
            string Titular = Console.ReadLine();

            Console.WriteLine("Já possui saldo? sim ou não");
            decimal saldo = 0.00m;

            string escolha;
            do
            {
                escolha = Console.ReadLine();
            } while (string.IsNullOrEmpty(escolha));

            if (escolha.Equals("Sim", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Digite o saldo");
                saldo = decimal.Parse(Console.ReadLine());
            }

            ContaCorrente cc = new ContaCorrente(Titular, contasPoupanca.Count + 1, saldo);
            contasCorrentes.Add(cc);
        }
        public void VisualizarContas()
        {
            Console.Clear();
            Console.WriteLine("--------- Contas Correntes ---------");
            foreach (var contas in contasCorrentes)
            {
                contas.ExibirDados();
                Console.WriteLine("---------");
            }

            Console.WriteLine("--------- Contas Poupanca ---------");
            foreach (var contas in contasPoupanca)
            {
                contas.ExibirDados();
                Console.WriteLine("---------");
            }
        }
        public void EscolherConta()
        {
            Console.Clear();
            Console.WriteLine("Conta poupança ou corrente");
            Console.WriteLine("1 - Poupança");
            Console.WriteLine("2 - Corrente");

            string opc = Console.ReadLine();

            switch (opc) 
            {
                case "1":
                    SaqueDepositoPoupança();
                    break;

                case "2":
                    SaqueDepositoCorrente();
                    break;
            }
        }
        public void SaqueDepositoPoupança()
        {
            Console.Clear();
            try
            {
                bool encontrado = false;
                Console.WriteLine("Digite o numero da conta");
                int numeroConta = int.Parse(Console.ReadLine());

                foreach (ContaPoupanca contas in contasPoupanca)
                {
                    if (contas.NumeroConta == numeroConta)
                    {
                        encontrado = true;
                        contas.ExibirSaldo();
                    }
                }
                if (encontrado == false) { throw new Exception(); }


                
                Console.WriteLine("Sacar ou depositar");
                Console.WriteLine("1 - Sacar");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Sair");

                string opc = Console.ReadLine();
                decimal quant;

                switch (opc)
                {
                    case "1":
                        Console.WriteLine("Digite a quantidade");
                        quant = decimal.Parse(Console.ReadLine());
                        
                        foreach (ContaPoupanca contas in contasPoupanca)
                        {
                            if (contas.NumeroConta == numeroConta)
                            {
                                contas.Sacar(quant);
                            }
                        }
                        break;

                    case "2":
                        Console.WriteLine("Digite a quantidade");
                        quant = decimal.Parse(Console.ReadLine());

                        foreach (ContaPoupanca contas in contasPoupanca)
                        {
                            if (contas.NumeroConta == numeroConta)
                            {
                                contas.Depositar(quant);
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine("Saindo");
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void SaqueDepositoCorrente()
        {
            Console.Clear();
            try
            {
                bool encontrado = false;
                Console.WriteLine("Digite o numero da conta");
                int numeroConta = int.Parse(Console.ReadLine());

                foreach (ContaCorrente contas in contasCorrentes)
                {
                    if (contas.NumeroConta == numeroConta)
                    {
                        encontrado = true;
                        contas.ExibirSaldo();
                    }
                }

                if (encontrado == false) { throw new Exception(); }

                Console.WriteLine("Sacar ou depositar");
                Console.WriteLine("1 - Sacar");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Sair");

                string opc = Console.ReadLine();
                decimal quant;

                switch (opc)
                {
                    case "1":
                        Console.WriteLine("Digite a quantidade");
                        quant = decimal.Parse(Console.ReadLine());

                        foreach (ContaCorrente contas in contasCorrentes)
                        {
                            if (contas.NumeroConta == numeroConta)
                            {
                                contas.Sacar(quant);
                            }
                        }
                        break;

                    case "2":
                        Console.WriteLine("Digite a quantidade");
                        quant = decimal.Parse(Console.ReadLine());

                        foreach (ContaCorrente contas in contasCorrentes)
                        {
                            if (contas.NumeroConta == numeroConta)
                            {
                                contas.Depositar(quant);
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine("Saindo");
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
