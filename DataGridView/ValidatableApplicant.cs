using System.ComponentModel.DataAnnotations;
using Library.Contracts.Models;
using System;

namespace DataGridView
{

    /// <summary>
    /// Класс для заполнения данных абитуриента
    /// </summary>
    public class ValidatableApplicant
    {
        /// <summary>
        /// Уникальный идентификатор абитуриента
        /// </summary>    
        public Guid Id { get; set; }
        /// <summary>
        /// ФИО
        /// </summary>
        [Required(ErrorMessage = "Введите ФИО")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Название - строка от 3 до 50 символов")]
        public string Name { get; set; }
        /// <summary>
        /// <inheritdoc cref="Library.Contracts.Models.Gender"/>
        /// </summary>
        [Required(ErrorMessage = "Выбирите ваш пол")]
        public Gender Gender { get; set; }

        /// <summary>
        /// День рождения
        /// </summary>
        [Required(ErrorMessage = "Выбирите вашу дату рождения")]
        public DateTime Birthday { get; set; }

        /// <summary>
        /// <inheritdoc cref="Library.Contracts.Models.Education"/>
        /// </summary>
        [Required(ErrorMessage = "Выбирите формат обучения")]
        public Education Education { get; set; }

        /// <summary>
        /// Баллы по математике
        /// </summary>
        [Range(0, 100)]
        [Required]
        public double Math { get; set; }

        /// <summary>
        /// Баллы по русскому языку
        /// </summary>
        [Range(0, 100)]
        [Required]
        public double Russian { get; set; }

        /// <summary>
        /// Баллы по информатике
        /// </summary>
        [Range(0, 100)]
        [Required]
        public double ComputerScience { get; set; }

        /// <summary>
        /// Сумма баллов за 3 экзамена ЕГЭ
        /// </summary>
        [Range(0, 300)]
        public double TotalScore { get; set; }
    }
}
