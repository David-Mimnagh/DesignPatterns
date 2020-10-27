using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Interface
{
    public interface ICalculatorStrategy
    {
        public int Calculate(int a, int b);
    }
}
