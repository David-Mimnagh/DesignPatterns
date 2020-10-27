using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Attributes
{
    [AttributeUsage(System.AttributeTargets.Class)]
    public class StrategyAttribute : System.Attribute
    {
        public int switchValue;
        public StrategyAttribute(int val)
        {
            this.switchValue = val;
        }
    }
}
