using System;
using BRQ_Teste_Credit_2022.DTO;
using BRQ_Teste_Credit_2022.Abstract;
using BRQ_Teste_Credit_2022.Business;
using System.Collections.Generic;
namespace Brq_Teste_Credit_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a data de referência, quantidade de trades e em seguida os trades");

            string dataReferencia = Console.ReadLine();
            string quantidadeTrades = Console.ReadLine();


            DateTime dataRef;
            int qtdeTrades;

            string msg = "";

            msg = validaParametros(dataReferencia, quantidadeTrades, out qtdeTrades, out dataRef).Trim();
            if (msg != string.Empty)
            {
                Console.WriteLine(String.Concat("Erro ", msg));
                return;
            }

            List<string> ret = new List<string>();

            List<TradeDTO> trades = new List<TradeDTO>();
            for (int cont = 0;  cont < qtdeTrades; cont++)
            {
                DateTime data;
                string trade = Console.ReadLine();

                string[] entrada = trade.Split(" ");

                if (entrada.Length != 3)
                {
                    Console.Write("Entrada inválida! Esperado: Valor Setor Data");
                    return;
                }
                double valor;
                if (!double.TryParse(entrada[0], out valor))
                {
                    Console.Write("Valor inválido");
                    return;
                }

                if (!DateTime.TryParse(entrada[2], out data))
                {
                    Console.WriteLine("Data Inválida");
                    return;
                }

                TradeDTO tradeDto = new TradeDTO(valor, entrada[1], data);
                aCategoryBusiness cat = new CategoryNotFoundBusiness(tradeDto);

                cat.Classifica(tradeDto, dataRef);
                ret.Add(tradeDto.Category);


            }

            Console.WriteLine("");
            Console.WriteLine("****  RESULTADO ****");
            Console.WriteLine("");
            ret.ForEach(i => Console.WriteLine(i));
                       

        }

        private static string validaParametros(string _dataReferencia, string _quantidadeTrades,  out int _qtdeTrade, out DateTime _dataRef)
        {

            string msg = "";

            DateTime dataRef;
            if (!DateTime.TryParse(_dataReferencia, out dataRef))
            {
                msg = string.Concat(msg, " - Data Inválida ");
            }


            int qtdeTrades;
            if (!int.TryParse(_quantidadeTrades, out qtdeTrades))
            {
                msg = string.Concat(msg, " - Quantidade deve ser númerico");
            }
            else 
            { 
                if (qtdeTrades == 0)
                {
                    msg = string.Concat(msg, " - Quantidade deve ser maior que zero");
                }
            }

            _qtdeTrade = qtdeTrades;
            _dataRef = dataRef;

            return msg;

        }

    }
}
