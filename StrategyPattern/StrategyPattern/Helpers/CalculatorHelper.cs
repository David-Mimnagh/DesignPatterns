using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace StrategyPattern.Helpers
{
    public class CalculatorHelper
    {
        public List<Type> GetAllImplementingClasses<T>()
        {
            Assembly asm = typeof(CalculatorHelper).Assembly;
            List<Type> typeList = new List<Type>();
            List<string> typeStrings = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                 .Where(x => typeof(T).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                 .Select(x => x.Name).ToList();
            foreach (var typeString in typeStrings)
            {
                typeList.Add(asm.GetTypes().First(t => t.Name == typeString));
            }
            return typeList;
        }
    }
}
