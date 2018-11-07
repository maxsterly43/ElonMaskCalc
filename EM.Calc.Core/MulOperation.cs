using System.Linq;

namespace EM.Calc.Core
{
    class MulOperation : IExtOperation
    {
        public string Name => "mul";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public string Uid => "{1CBC754A-4AA6-4FA6-BE6E-F8BC1B617AE0}";

        public string Description => "Выполняет последовательное умножение";

        public int? ArgCout => 2;

        public double? Execute()
        {
            Result = Operands.Aggregate((a, b) => a * b);
            return Result;
        }
    }
}
