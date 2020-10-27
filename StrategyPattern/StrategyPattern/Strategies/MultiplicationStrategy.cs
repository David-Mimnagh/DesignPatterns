using StrategyPattern.Attributes;
using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategies
{
    [StrategyAttribute(3)]
    class MultiplicationStrategy : ICalculatorStrategy
    {
        public int Calculate(int a, int b)
        {
            return a * b;
        }
    }
}
