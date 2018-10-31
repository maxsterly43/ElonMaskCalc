using System.Linq;

namespace EM.Calc.Core
{
    class SubOperation : IOperation
    {
        public string Name => "sub";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public double? Execute()
        {
            Result = Operands.Select((item, i) => i > 0 ? -item : item).Sum();
            return Result;
        }
    }
}