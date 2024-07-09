using System;

namespace TipCalculator.Models
{
    public class Meal
    {
        public decimal Cost { get; set; }

        public decimal CalculateTip(decimal percentage)
        {
            return Cost * percentage / 100;
        }
    }
}