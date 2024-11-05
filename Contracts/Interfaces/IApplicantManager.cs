using DataGridView.Standart.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataGridView.Standart.Contracts.Interfaces
{
    public interface IApplicantManager
    {
        /// <summary>
        /// Асинхронное получение всех данных
        /// </summary
        Task<IReadOnlyCollection<Applicant>> GetAllAsync();
        /// <summary>
        /// Асинхронная операция добавления
        /// </summary>
        Task<Applicant> AddAsync(Applicant applicant);
        /// <summary>
        /// Асинхронная операция изменения
        /// </summary>
        Task EditAsync(Applicant applicant);
        /// <summary>
        /// Асинхронная операция удаления
        /// </summary>
        Task<bool> DeleteAsync(Guid id);
        /// <summary>
        /// Асинхронная получение суммарных данных
        /// </summary>
        Task<IApplicantStats> GetStatsAsync();
    }
}
