using System;
using System.Linq;

namespace EM.Calc.ConsoleApp
{
    public class Program
    {
        public enum cmds
        {
            sum = 0,
            sub = 1,
            pow = 2
        }
        static void Main(string[] args)
        {
            try
            {
                Core.Calc calc = new Core.Calc();
                Console.WriteLine("Введите одну из операций: sum, sub, pow.\nПриемер: sum 5 3 2");
                string[] input = Console.ReadLine().Split(' ');
                cmds cm;
                if (!Enum.TryParse(input[0], out cm)) throw new Exception("Некорректный ввод");
                int[] arr = input.Skip(1).Select(x =>
                {
                    int r;
                    if (int.TryParse(x.ToString(), out r))
                        return r;
                    else
                        throw new Exception("Некорректный ввод");
                }).ToArray();
                long res = 0;
                switch (cm)
                {
                    case cmds.sum:
                        res = calc.Sum(arr);
                        break;

                    case cmds.sub:
                        res = calc.Sub(arr);
                        break;
                    case cmds.pow:
                        res = calc.Pow(arr);
                        break;
                }

                Console.WriteLine(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {   
                Console.ReadKey();
            }
        }
    }
}