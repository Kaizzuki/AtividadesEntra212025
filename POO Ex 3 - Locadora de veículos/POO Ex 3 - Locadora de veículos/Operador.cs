using POO_Ex_3___Locadora_de_veículos.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex_3___Locadora_de_veículos
{
    public class Operador
    {
        private List<IVeiculo> listaVeiculos = new List<IVeiculo>();
        public void ExibirLista()
        {
            if (listaVeiculos.Count <= 0)
            {
                Console.WriteLine("Nenhum veiculo cadastrado!");
            }
            else
            {
                Console.WriteLine("Veiculos: ");
                foreach (IVeiculo veiculo in listaVeiculos)
                {
                    Console.WriteLine("---------");
                    veiculo.Exibir();
                }
                Console.WriteLine("---------");
            }
        }

        public double AskNumber(string? Pergunta)
        {
            double resposta;
            if (!string.IsNullOrEmpty(Pergunta))
            {
                Console.WriteLine(Pergunta);
            }

            while (true)
            {
                string SResposta = Console.ReadLine();
                if (double.TryParse(SResposta, out resposta))
                {
                    return resposta;
                }
                else
                {
                    Console.WriteLine("Resposta invalida. {0}", Pergunta);
                }
            }
        }
        public string AskString(string? Pergunta)
        {
            string resposta;
            if (!string.IsNullOrEmpty(Pergunta))
            {
                Console.WriteLine(Pergunta);
            }

            while (true)
            {
                resposta = Console.ReadLine();

                if (!string.IsNullOrEmpty(resposta))
                {
                    return resposta;
                }
                else
                {
                    Console.WriteLine("Resposta vazia. {0}", Pergunta);
                }
            }
        }

        //CADASTROS
        public void CadastrarNovoVeiculo()
        {
            Console.WriteLine("Tipos: Carro, Caminhao, Moto");
            string opcao = this.AskString("Digite o tipo do veiculo").ToLower();

            switch(opcao)
            {
                case "carro":
                    listaVeiculos.Add( CadastrarCarro() );
                    break;

                case "caminhao":
                    listaVeiculos.Add( CadastrarCaminhao() );
                    break;

                case "moto":
                    listaVeiculos.Add( CadastrarMoto() );
                    break;

                default: 
                    Console.WriteLine("Invalida");
                    break;
            }

        }
        public Carro CadastrarCarro()
        {
            string marca = AskString("Qual a marca do carro");
            string modelo = AskString("Qual o modelo do carro");
            int ano = (int)AskNumber("Qual o ano do carro");
            decimal aluguel = (decimal)AskNumber("Qual o valor da diaria base do aluguel");

            Carro novoCarro = new Carro(modelo, marca, ano, aluguel);
            return novoCarro;
        }
        public Moto CadastrarMoto()
        {
            string marca = AskString("Qual a marca da moto");
            string modelo = AskString("Qual o modelo da moto");
            int ano = (int)AskNumber("Qual o ano da moto");
            decimal aluguel = (decimal)AskNumber("Qual o valor da diaria base do aluguel");

            Moto novoMoto = new Moto(modelo, marca, ano, aluguel);
            return novoMoto;

        }
        public Caminhao CadastrarCaminhao()
        {
            string marca = AskString("Qual a marca do caminhão");
            string modelo = AskString("Qual o modelo do caminhão");
            int ano = (int)AskNumber("Qual o ano do caminhão");
            decimal aluguel = (decimal)AskNumber("Qual o valor da diaria base do aluguel");

            Caminhao novoCaminhao = new Caminhao(modelo, marca, ano, aluguel);
            return novoCaminhao;

        }
        public void alugar()
        {
            //Selecionar veiculo
            ExibirLista();
            if (listaVeiculos.Count <= 0)
                return;
            string marcaVeiculo = AskString("Digite a marca do veiculo");
            string modeloVeiculo = AskString("Digite o modelo do veiculo");
            int anoVeiculo = (int)AskNumber("Digite o ano do veiculo");

            foreach (Veiculo veiculo in listaVeiculos)
            {
                //Confirmação
                bool mesmoModelo = veiculo.Modelo.Equals(modeloVeiculo, StringComparison.OrdinalIgnoreCase);
                bool mesmoMarca = veiculo.Marca.Equals(marcaVeiculo, StringComparison.OrdinalIgnoreCase);
                bool mesmoAno = veiculo.Ano.Equals(anoVeiculo);

                if (mesmoModelo && mesmoAno && mesmoMarca)
                {
                    int dias = (int)AskNumber("Digite por quantos dias deseja alugar");
                    Console.WriteLine($"O valor de aluguel de {dias} dias é: {veiculo.CalcularAluguel(dias)}");
                }
            }
        }

        //MENUS
        public void MenuPrincipal()
        {
            bool ativo = true;

            while (ativo)
            {
                Console.WriteLine("------ Menu Locadora ------");

                Console.WriteLine("1 - Cadastrar novo veiculo");
                Console.WriteLine("2 - Visualizar veiculos cadastrados");
                Console.WriteLine("3 - Alugar veiculo");
                Console.WriteLine("0 - Sair");

                string escolha = AskString("Escolha");

                switch (escolha)
                {
                    case "1":
                        Console.Clear();
                        CadastrarNovoVeiculo();
                        break;

                    case "2":
                        Console.Clear();
                        ExibirLista();
                        break;

                    case "3":
                        Console.Clear();
                        alugar();
                        break;

                    case "0":
                        Console.WriteLine("Até mais!");
                        ativo = false;
                        break;
                }
            }
        }
    }
}
