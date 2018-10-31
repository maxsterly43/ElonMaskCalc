namespace EM.Calc.Core
{
    /// <summary>
    /// Операция
    /// </summary>
    public interface IOperation
    {
        /// <summary>
        /// Имя операции
        /// </summary>
        string Name { get; }

        /// Операнды
        /// </summary>
        double[] Operands { get; set; }

        /// <summary>
        /// Выполнить операцию
        /// </summary>
        /// <returns>Возвращает результат операции</returns>
        double? Execute();

        /// <summary>
        /// Результат операции
        /// </summary>
        double? Result { get; }
    }
}