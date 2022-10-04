using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BRQ_Teste_Credit_2022.Interfaces;

namespace BRQ_Teste_Credit_2022.DTO
{
    public class TradeDTO:  ITrade
    {
        [Required]
        [Range(0.01, 999999999.99)]
        public double Value { get; }
        [Required]
        public string ClientSector { get; }

        [Required]
        public DateTime NextPaymentDate { get; }

        public String Category { get; set; }

        public TradeDTO(double Valor, string Setor, DateTime Data)
        {
            Value = Valor;
            ClientSector = Setor;
            NextPaymentDate = Data;
        }
    }
}
