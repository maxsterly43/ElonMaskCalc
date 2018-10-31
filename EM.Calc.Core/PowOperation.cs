using System;
using System.Linq;

namespace EM.Calc.Core
{
    class PowOperation : IOperation
    {
        public string Name => "pow";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public double? Execute()
        {
            Result = Operands.Aggregate((a, b) => Math.Pow(a, b));
            return Result;
        }
    }
}