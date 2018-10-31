﻿namespace EM.Calc.Core
{
    /// <summary>
    /// Операция
    /// </summary>
    public interface IExOperation : IOperation
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        string Uid { get; }

        /// <summary>
        /// Описание
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Количество аргументов
        /// </summary>
        int? ArgCout { get; }
    }
}