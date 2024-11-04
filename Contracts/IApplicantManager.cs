using Library.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts
{
    public interface IApplicantManager
    {
        /// <summary>
        /// Получение всех данных абитуриентов
        /// </summary>
        Task<IReadOnlyCollection<Applicant>> GetApplicant();
        /// <summary>
        /// Добавление абитуриента
        /// </summary>
        Task<Applicant> AddApplicant(Applicant applicant);
        /// <summary>
        /// Изменение абитуриента
        /// </summary>
        Task EditApplicant(Applicant applicant);
        /// <summary>
        /// Удаление абитуриента
        /// </summary>
        Task<bool> DeleteApplicant(Guid id);
        /// <summary>
        /// Получение общих данных абитуриента
        /// </summary>
        Task<IApplicantStats> GetStatsApplicant();
    }
}
