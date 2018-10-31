using System;
using System.Linq;

namespace EM.Calc.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Core.Calc calc = new Core.Calc();
                string operation;
                double[] operands;
                if (args.Length == 0)
                {
                    Console.Write("Список операций:");
                    foreach (var item in calc.GetOperationsName)
                        Console.Write($" {item}");
                    Console.Write("\nВведите операцию: ");
                    operation = Console.ReadLine().ToLower().Trim();
                    Console.Write("Введите аргументы через пробел: ");
                    string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    operands = convertToDouble(input);
                }
                else
                {
                    operation = args[0].ToLower().Trim();
                    operands = convertToDouble(args, 1);
                }
                var res = calc.Execute(operation, operands);
                if (res == null) throw new Exception("Введенная операция отсутствует.");
                Console.WriteLine($"Результат операции: {res}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
                Console.Clear();
            }
        }

        private static double[] convertToDouble(string[] input, int i = 0)
        {
            double r;
            return input.Skip(i).Select(x =>
            {
                if (double.TryParse(x.ToString(), out r)) return r;
                else throw new Exception("Некорректный ввод списка чисел.");
            }).ToArray();
        }
    }
}