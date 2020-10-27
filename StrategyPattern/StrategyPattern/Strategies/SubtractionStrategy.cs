using StrategyPattern.Attributes;
using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategies
{
    [StrategyAttribute(2)]
    class SubtractionStrategy : ICalculatorStrategy
    {
        public int Calculate(int a, int b)
        {
            return a - b;
        }
    }
}
