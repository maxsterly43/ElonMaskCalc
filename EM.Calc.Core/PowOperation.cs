using System;
using System.Linq;

namespace EM.Calc.Core
{
    class PowOperation : IExtOperation
    {
        public string Name => "pow";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public string Uid => "{28FC44F5-A6EA-498E-B960-F6AAD64E138E}";

        public string Description => "Выполняет последовательное возведение в степень";

        public int? ArgCout => 2;

        public double? Execute()
        {
            Result = Operands.Aggregate((a, b) => Math.Pow(a, b));
            return Result;
        }
    }
}