using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Service
{
    public interface IPromotionRules
    {
        PromotionCart PromotionRules_3A(List<char> products);
        PromotionCart PromotionRules_2B(List<char> products);

        PromotionCart PromotionRules_CD(List<char> products);
    }
}
