using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BRQ_Teste_Credit_2022.DTO;
using BRQ_Teste_Credit_2022.Abstract;

namespace BRQ_Teste_Credit_2022.Business 
{
    public class CategoryHighRiskBusiness : aCategoryBusiness
    {

        public CategoryHighRiskBusiness(TradeDTO trade)
        {
            this.tradeDTO = trade;
        }
        public override void Classifica(TradeDTO trade, DateTime dataRef)
        {
            if (trade.Value > 1000000 && trade.ClientSector == "Private")
            { 
                this.tradeDTO.Category = "High Risk";
            }
            else
            {
                aCategoryBusiness categoria = new CategoryMediumRiskBusiness(trade);
                categoria.Classifica(trade, dataRef);
            }
        }

    }


}
