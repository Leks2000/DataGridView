using System.Data.Entity;
using DataGridView.Standart.Contracts.Models;

namespace DataGridView.Database
{
    /// <summary>
    /// Контекст базы данных
    /// </summary>
    public class DBApplicantContext : DbContext
    {
        /// <summary>
        /// Конструктор контекста базы данных
        /// </summary>
        public DBApplicantContext() : base("ApplicantDatabase")
        {
        }

        /// <summary>
        /// Таблица <see cref="Applicant"/> в базе данных
        /// </summary>
        public DbSet<Applicant> Applicants { get; set; }
    }
}
