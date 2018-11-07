using System.Linq;

namespace EM.Calc.Core
{
    class SubOperation : IExtOperation
    {
        public string Name => "sub";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public string Uid => "{B0D62669-43BE-45D9-A429-CBD8AF4FEAFB}";

        public string Description => "Выполняет последовательное вычитание";

        public int? ArgCout => 2;

        public double? Execute()
        {
            Result = Operands.Select((item, i) => i > 0 ? -item : item).Sum();
            return Result;
        }
    }
}