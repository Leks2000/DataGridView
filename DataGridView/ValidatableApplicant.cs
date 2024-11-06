using System.ComponentModel.DataAnnotations;
using System;

namespace DataGridView.Standart.Contracts.Models
{

    /// <summary>
    /// Класс для заполнения данных абитуриента
    /// </summary>
    public class ValidatableApplicant
    {
        /// <summary>
        /// Уникальный идентификатор абитуриента
        /// </summary>    
        public Guid Id { get; set; } = Guid.NewGuid();
        /// <summary>
        /// ФИО
        /// </summary>
        [Required(ErrorMessage = "Введите ФИО")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Название - строка от 3 до 50 символов")]
        public string Name { get; set; } = "ФИО";
        /// <summary>
        /// <inheritdoc cref="Standart.Models.Gender"/>
        /// </summary>
        [Required(ErrorMessage = "Выбирите ваш пол")]
        public Gender Gender { get; set; } = Gender.Male;

        /// <summary>
        /// День рождения
        /// </summary>
        [Required(ErrorMessage = "Выбирите вашу дату рождения")]
        public DateTime Birthday { get; set; } = new DateTime(2000, 1, 1);

        /// <summary>
        /// <inheritdoc cref="Models"/>
        /// </summary>
        [Required(ErrorMessage = "Выбирите формат обучения")]
        public Education Education { get; set; } = Education.Сorrespondence;

        /// <summary>
        /// Баллы по математике
        /// </summary>
        [Range(0, 100)]
        [Required]
        public double Math { get; set; } = 80;

        /// <summary>
        /// Баллы по русскому языку
        /// </summary>
        [Range(0, 100)]
        [Required]
        public double Russian { get; set; } = 70;

        /// <summary>
        /// Баллы по информатике
        /// </summary>
        [Range(0, 100)]
        [Required]
        public double ComputerScience { get; set; } = 60;

        /// <summary>
        /// Сумма баллов за 3 экзамена ЕГЭ
        /// </summary>
        [Range(0, 300)]
        public double TotalScore { get; set; }
    }
}
