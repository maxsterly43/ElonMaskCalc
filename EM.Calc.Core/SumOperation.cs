using System.Linq;

namespace EM.Calc.Core
{
    class SumOperation : IExtOperation
    {
        public string Name => "sum";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public string Uid => "{E6B892BF-BDDE-4CF3-B438-20A5CA884C50}";

        public string Description => "Выполняет последовательное сложение";

        public int? ArgCout => 2;

        public double? Execute()
        {
            Result = Operands.Sum();
            return Result;
        }
    }
}