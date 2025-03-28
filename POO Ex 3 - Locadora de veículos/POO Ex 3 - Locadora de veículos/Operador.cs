﻿using POO_Ex_3___Locadora_de_veículos.Veiculos;
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
            string opcao = this.AskString("Digite o tipo do veiculo");
            opcao.ToLower();

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
            string modelo = AskString("Qual o modelo do carro");
            string marca = AskString("Qual a marca do carro");
            int ano = (int)AskNumber("Qual o ano do carro");
            decimal aluguel = (decimal)AskNumber("Qual o valor da diaria base do aluguel");

            Carro novoCarro = new Carro(modelo, marca, ano, aluguel);
            return novoCarro;
        }
        public Moto CadastrarMoto()
        {
            string modelo = AskString("Qual o modelo da moto");
            string marca = AskString("Qual a marca da moto");
            int ano = (int)AskNumber("Qual o ano da moto");
            decimal aluguel = (decimal)AskNumber("Qual o valor da diaria base do aluguel");

            Moto novoMoto = new Moto(modelo, marca, ano, aluguel);
            return novoMoto;

        }
        public Caminhao CadastrarCaminhao()
        {
            string modelo = AskString("Qual o modelo do caminhão");
            string marca = AskString("Qual a marca do caminhão");
            int ano = (int)AskNumber("Qual o ano do caminhão");
            decimal aluguel = (decimal)AskNumber("Qual o valor da diaria base do aluguel");

            Caminhao novoCaminhao = new Caminhao(modelo, marca, ano, aluguel);
            return novoCaminhao;

        }

    }
}
