using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BRQ_Teste_Credit_2022.DTO;
using BRQ_Teste_Credit_2022.Abstract;

namespace BRQ_Teste_Credit_2022.Business 
{
    public class CategoryMediumRiskBusiness : aCategoryBusiness
    {
        public CategoryMediumRiskBusiness(TradeDTO trade)
        {
            this.tradeDTO = trade;
        }

        public override void Classifica(TradeDTO trade, DateTime dataRef)
        {
            if (trade.Value > 1000000 && trade.ClientSector == "Public")
            { 
                this.tradeDTO.Category = "Medium Risk";
            }


        }
    }


}
