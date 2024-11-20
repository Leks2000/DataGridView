using DataGridView.Standart.Contracts.Interfaces;
using DataGridView.Standart.Contracts.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using DataGridView.Standart.Manager.Models;
using System.Linq;


namespace DataGridView.Standart.Manager
{
    /// <summary>
    /// Реализация редактирования, добавления, удаления и получения абитуриентов
    /// Логирование всех операций для отклдаки времени выполнения и ошибок.
    /// </summary>
    public class ApplicantManager : IApplicantManager
    {
        private readonly IApplicantStorage applicantStorage;
        private readonly ILogger logger;
        public ApplicantManager(IApplicantStorage applicantStorage, ILogger logger)
        {
            this.logger = logger;
            this.applicantStorage = applicantStorage;
        }
        /// <inheritdoc cref="IApplicantManager.AddAsync(Applicant)"/>
        async Task<Applicant> IApplicantManager.AddAsync(Applicant applicant)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Applicant result;
            try
            {
                result = await applicantStorage.AddAsync(applicant);
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                LoggingHelper.LogErrorApplicant(
                    logger,
                    nameof(IApplicantManager.AddAsync),
                    applicant.Id,
                    stopwatch.ElapsedMilliseconds,
                    ex.Message,
                    applicant
                    );
                return null;
            }

            stopwatch.Stop();
            LoggingHelper.LogInfoApplicant(
                logger,
                nameof(IApplicantManager.AddAsync),
                applicant.Id,
                stopwatch.ElapsedMilliseconds,
                applicant
                );
            return result;
        }
        /// <inheritdoc cref="IApplicantManager.DeleteAsync(Guid)"/>
        async Task<bool> IApplicantManager.DeleteAsync(Guid id)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            bool result;
            try
            {
                result = await applicantStorage.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                LoggingHelper.LogErrorApplicant(logger, nameof(IApplicantManager.DeleteAsync),
                         id,
                         stopwatch.ElapsedMilliseconds,
                         ex.Message
                         );
                return false;
            }

            stopwatch.Stop();
            LoggingHelper.LogInfoApplicant(logger, nameof(IApplicantManager.DeleteAsync),
                    id,
                    stopwatch.ElapsedMilliseconds
                );
            return result;
        }
        /// <inheritdoc cref="IApplicantManager.EditAsync(Applicant)"/>
        async Task IApplicantManager.EditAsync(Applicant applicant)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            try
            {
                await applicantStorage.EditAsync(applicant);
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                LoggingHelper.LogErrorApplicant(logger, nameof(IApplicantManager.EditAsync),
                         applicant.Id,
                         stopwatch.ElapsedMilliseconds,
                         ex.Message,
                         applicant
                         );
            }

            stopwatch.Stop();
            LoggingHelper.LogInfoApplicant(logger, nameof(IApplicantManager.EditAsync),
                    applicant.Id,
                    stopwatch.ElapsedMilliseconds,
                    applicant
                );
        }
        /// <inheritdoc cref="IApplicantManager.GetAllAsync()"/>
        async Task<IReadOnlyCollection<Applicant>> IApplicantManager.GetAllAsync()
        {
            try
            {
                return await applicantStorage.GetAllAsync();
            }
            catch (Exception ex)
            {
                LoggingHelper.LogError(logger, nameof(IApplicantManager.GetAllAsync), ex.Message);
            }
            return null;
        }
        /// <inheritdoc cref="IApplicantManager.GetAllAsync()"/>
        async Task<IApplicantStats> IApplicantManager.GetStatsAsync()
        {
            try
            {
                var result = await applicantStorage.GetAllAsync();
                return new ApplicantStatsModel
                {
                    Count = result.Count,
                    MaleCount = result.Where(x => x.Gender == Gender.Male).Count(),
                    FemaleCount = result.Where(x => x.Gender == Gender.Female).Count(),
                    FullTimeCount = result.Where(x => x.Education == Education.FullTime).Count(),
                    FullTimePartTimeCount = result.Where(x => x.Education == Education.FullTimePartTime).Count(),
                    СorrespondenceCount = result.Where(x => x.Education == Education.Сorrespondence).Count(),
                    TotalScoreCount = result.Where(x => x.TotalScore >= 150).Count(),
                };
            }
            catch (Exception ex)
            {
                LoggingHelper.LogError(logger, nameof(IApplicantManager.GetStatsAsync), ex.Message);
            }
            return null;
        }
    }
}