using StrategyPattern.Attributes;
using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategies
{
    [StrategyAttribute(1)]
    public class AdditionStrategy : ICalculatorStrategy
    {
        public int Calculate(int a, int b)
        {
            return a + b;
        }
    }
}
