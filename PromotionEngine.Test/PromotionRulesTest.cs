using System;
using System.Collections.Generic;
using System.Text;
using PromotionEngine.Service;
using PromotionEngine.Models;
using NUnit.Framework;

namespace PromotionEngine.Test
{
    [TestFixture]
    public class PromotionRulesTest
    {
        [TestCase]
        public void PromotionRules_Should_Return_130_When_AAA()
        {
            PromotionRules promotionRules = new PromotionRules();

           var output= promotionRules.PromotionRules_3A(new List<char>() { 'A', 'A', 'A' });

            Assert.AreEqual(ApplicationConstants.A_3, output.PromotionCartPrice);
        }

        [TestCase]
        public void PromotionRules_Should_Return_45_When_BB()
        {
            PromotionRules promotionRules = new PromotionRules();

            var output = promotionRules.PromotionRules_2B(new List<char>() { 'B','B'});

            Assert.AreEqual(ApplicationConstants.B_2, output.PromotionCartPrice);
        }

        [TestCase]
        public void PromotionRules_Should_Return_30_When_CD()
        {
            PromotionRules promotionRules = new PromotionRules();

            var output = promotionRules.PromotionRules_CD(new List<char>() { 'C','D' });

            Assert.AreEqual(ApplicationConstants.C_D, output.PromotionCartPrice);
        }
    }
}
