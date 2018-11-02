using System.Linq;

namespace EM.Calc.Core
{
    class SumOperation : IExtOperation
    {
        public string Name => "sum";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public string Uid => throw new System.NotImplementedException();

        public string Description => "Выполняет последовательное сложение";

        public int? ArgCout => 2;

        public double? Execute()
        {
            Result = Operands.Sum();
            return Result;
        }
    }
}