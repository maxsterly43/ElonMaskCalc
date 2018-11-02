using System.Linq;

namespace EM.Calc.Core
{
    class MulOperation : IExtOperation
    {
        public string Name => "mul";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public string Uid => throw new System.NotImplementedException();

        public string Description => "Выполняет последовательное умножение";

        public int? ArgCout => 2;

        public double? Execute()
        {
            Result = Operands.Aggregate((a, b) => a * b);
            return Result;
        }
    }
}
