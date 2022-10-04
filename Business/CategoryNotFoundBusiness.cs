using System;
using BRQ_Teste_Credit_2022.DTO;
using BRQ_Teste_Credit_2022.Abstract;

namespace BRQ_Teste_Credit_2022.Business 
{
    public class CategoryNotFoundBusiness : aCategoryBusiness
    {

        public CategoryNotFoundBusiness(TradeDTO trade)
        {
            this.tradeDTO = trade;
        }

        public override void Classifica(TradeDTO trade, DateTime dataRef)
        {
            this.tradeDTO.Category = "Not Found";

            aCategoryBusiness categoria = new CategoryExpiredBusiness(trade);
            categoria.Classifica(trade, dataRef);

        }


    }


}
