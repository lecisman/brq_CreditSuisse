using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BRQ_Teste_Credit_2022.DTO;
using BRQ_Teste_Credit_2022.Abstract;

namespace BRQ_Teste_Credit_2022.Business 
{
    public class CategoryExpiredBusiness : aCategoryBusiness
    {
        public CategoryExpiredBusiness(TradeDTO trade)
        {
            this.tradeDTO = trade;
        }
        public override void Classifica(TradeDTO trade, DateTime dataRef)
        {
            if ((dataRef - trade.NextPaymentDate ).TotalDays > 30)
            {
                this.tradeDTO.Category = "Expired";
            }
            else
            { 
                aCategoryBusiness categoria = new CategoryHighRiskBusiness(trade);
                categoria.Classifica(trade, dataRef);
            }
        }

    }


}
