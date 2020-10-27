using StrategyPattern.Attributes;
using StrategyPattern.Helpers;
using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace StrategyPattern.Context
{
    public class CalculatorContext
    {
        ICalculatorStrategy strategy;
        CalculatorHelper helper = new CalculatorHelper();
        public string GetCorrectStrategy(int switchVal)
        {
           var strategies = helper.GetAllImplementingClasses<ICalculatorStrategy>();
           return strategies.FirstOrDefault(s => s.GetCustomAttribute<StrategyAttribute>().switchValue == switchVal).Name;
        }
        public void SetStrategy(ICalculatorStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int ExecuteStrategy(int a, int b)
        {
            return this.strategy.Calculate(a, b);
        }
    }
}
