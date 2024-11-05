using Library.Contracts.Models;

namespace DataGridView
{
    /// <summary>
    /// Класс для приведения одного типа к другому
    /// </summary>
    public static class Convert
    {
        /// <summary>
        /// Привести <see cref="Applicant"/> к <see cref="ValidatableApplicant"/>
        /// </summary>
        public static Applicant ToValidateApplicant(ValidatableApplicant validateApplicant)
        {
            return new Applicant()
            {
                Id = validateApplicant.Id,
                Name = validateApplicant.Name,
                Gender = validateApplicant.Gender,
                Birthday = validateApplicant.Birthday,
                Education = validateApplicant.Education,
                Math = validateApplicant.Math,
                Russian = validateApplicant.Russian,
                ComputerScience = validateApplicant.ComputerScience,
            };
        }
        /// <summary>
        /// Привести <see cref="ValidateApplicant"/> к <see cref="Applicant"/>
        /// </summary>
        public static ValidatableApplicant ToApplicant(Applicant applicant)
        {
            return new ValidatableApplicant()
            {
                Id = applicant.Id,
                Name = applicant.Name,
                Gender = applicant.Gender,
                Birthday = applicant.Birthday,
                Education = applicant.Education,
                Math = applicant.Math,
                Russian = applicant.Russian,
                ComputerScience = applicant.ComputerScience,
            };
        }

    }
}
