using System.Linq;

namespace EM.Calc.Core
{
    class MulOperation : IOperation
    {
        public string Name => "mul";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public double? Execute()
        {
            Result = Operands.Aggregate((a, b) => a * b);
            return Result;
        }
    }
}
