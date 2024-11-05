using DataGridView.Standart.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataGridView.Standart.Contracts.Interfaces
{
    /// <summary>
    /// Интерфейс прослойки между <see cref="MemoryApplicantStorage"/> и представлением
    /// </summary>
    public interface IApplicantStorage
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
    }
}
