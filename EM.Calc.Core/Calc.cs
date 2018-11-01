using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EM.Calc.Core
{
    public class Calc
    {
        private IList<IOperation> Operations { get; set; }
        public string[] GetOperationsName => Operations.Select(i => i.Name).ToArray();
        public Calc()
        {
            Operations = new List<IOperation>();
            findDllFiles();
        }

        private void findDllFiles()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
            var dllFiles = Directory.GetFiles(path, "*.dll", SearchOption.TopDirectoryOnly);
            foreach (var file in dllFiles)
                FindOperations(Assembly.LoadFrom(file));
        }

        private void FindOperations(Assembly assembly)
        {
            var types = assembly.GetTypes();
            var needType = typeof(IOperation);
            foreach (var item in types.Where(t => t.IsClass && !t.IsAbstract))
            { 
                    var interfaces = item.GetInterfaces();
                    if (interfaces.Contains(needType))
                    {
                        var instance = Activator.CreateInstance(item);
                        var operation = instance as IOperation;
                        if (operation != null)
                            Operations.Add(operation);
                    }
                } 
        }

        public double? Execute(string operation, double[] operands)
        {
            IOperation op = Operations.SingleOrDefault(i => i.Name == operation);
            if (op != null)
                op.Operands = operands;
            return op?.Execute();
        }

        #region old function
        [Obsolete("Существует новый функционал - Execute(\"sum\", operands)")]
        public double? Sum(double[] args)
        {
            return Execute("sum", args);
        }
        [Obsolete("Существует новый функционал - Execute(\"sub\", operands)")]
        public double? Sub(double[] args)
        {
            return Execute("sub", args);
        }
        [Obsolete("Существует новый функционал - Execute(\"pow\", operands)")]
        public double? Pow(double[] args)
        {
            return Execute("pow", args);
        }
        #endregion
    }
}