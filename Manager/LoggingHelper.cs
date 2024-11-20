using DataGridView.Standart.Contracts.Models;
using Microsoft.Extensions.Logging;
using System;
using static System.Collections.Specialized.BitVector32;

namespace DataGridView.Standart.Manager
{
    public class LoggingHelper
    {
  
        /// <summary>
        /// Залогировать информацию о действии с абитуриентом
        /// </summary>
        public static void LogErrorApplicant(ILogger logger, string actionName, Guid applicantId, long msElapsed, string errorMessage, Applicant applicant = null)
        {
            logger.LogError(
                "Действие { ACTION} с идентификатором { ID} выполнено за: {Milliseconds} мс; дата: {DATE}; " +
                "сообщение об ошибке: {ERROR}",
                actionName,
                applicantId,
                applicant,
                msElapsed,
                DateTime.Now,
                errorMessage
                );
        }

        /// <summary>
        /// Логирование ошибки при действии с абитуриентом
        /// </summary>
        public static void LogInfoApplicant(ILogger logger, string actionName, Guid applicantId, long msElapsed, Applicant applicant = null)
        {
            logger.LogInformation(
                "Действие {ACTION} с идентификатором {ID}," +
                " выполнено за: {Milliseconds} мс; дата: {DATE}; " +
                "сообщение об ошибке: {ERROR}",
                actionName,
                applicantId,
                msElapsed,
                DateTime.Now,
                applicant
                );
        }

        /// <summary>
        /// Логирование ошибки
        /// </summary>
        public static void LogError(ILogger logger, string actionName, string errorMessage)
        {
            logger.LogError(
            "Не удалось завершить Действие {ACTION}, дата: {DATE}; сообщение об ошибке: {ERROR}",
            actionName,
            DateTime.Now,
            errorMessage
            );
        }
    }
}
