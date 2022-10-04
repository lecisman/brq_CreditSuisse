using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRQ_Teste_Credit_2022.Interfaces
{
    public interface ITrade
    {
        public double Value { get; }
        public string ClientSector { get; }
        public DateTime NextPaymentDate { get; }
    }
}
