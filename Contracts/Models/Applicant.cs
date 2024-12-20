﻿using System;

namespace DataGridView.Standart.Contracts.Models
{
    /// <summary>
    /// Класс для заполнения данных абитуриента
    /// </summary>
    public class Applicant
    {
        public Guid Id { get; set; }
        /// <summary>
        /// ФИО
        /// </summary>

        public string Name { get; set; }
        /// <summary>
        /// <inheritdoc cref="Models.Gender"/>
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// День рождения
        /// </summary>

        public DateTime Birthday { get; set; }

        /// <summary>
        /// <inheritdoc cref="Models.Education"/>
        /// </summary>

        public Education Education { get; set; }

        /// <summary>
        /// Баллы по математике
        /// </summary>

        public double Math { get; set; }

        /// <summary>
        /// Баллы по русскому языку
        /// </summary>

        public double Russian { get; set; }

        /// <summary>
        /// Баллы по информатике
        /// </summary>

        public double ComputerScience { get; set; }

        /// <summary>
        /// Сумма баллов за 3 экзамена ЕГЭ
        /// </summary>

        public double TotalScore { get; set; }
    }
}
