using System;
using BRQ_Teste_Credit_2022.DTO;


namespace BRQ_Teste_Credit_2022.Abstract
{
    public abstract class aCategoryBusiness
    {

        public TradeDTO tradeDTO { get; set; }

        public abstract void Classifica(TradeDTO trade,DateTime dataRef);

    }


}
