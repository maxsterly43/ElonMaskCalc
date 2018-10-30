using System;
using System.Linq;

namespace EM.Calc.Core
{
    public class Calc
    {
        public int Sum(int[] args)
        {
            return args.Sum();
        }
        public int Sub(int[] args)
        {
            return args.Select((item, j) => j > 0 ? -item : item).ToArray().Sum();
        }
        public long Pow(int[] args)
        {
            double result = 0;
            for (int j = 0; j < args.Length; j++)
                result = j > 0 ? Math.Pow(result, args[j]) : args[j];
            return Convert.ToInt64(result);
        }
    }
}