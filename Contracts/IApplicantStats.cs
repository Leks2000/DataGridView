using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Contracts
{
    public interface IApplicantStats
    {
        /// <summary>
        /// Общее количество абитуриентов
        /// </summary>
        int Count { get; }
        /// <summary>
        /// Количество абитуриентов женского пола
        /// </summary>
        int FemaleCount { get; }
        /// <summary>
        /// Количество абитуриентов мужского пола
        /// </summary>
        int MaleCount { get; }
        /// <summary>
        /// Количество абитуриентов на очном обучении
        /// </summary>
        int FullTimeCount { get; }
        /// <summary>
        /// Количество абитуриентов на очно-заочном обучении
        /// </summary>
        int FullTimePartTimeCount { get; }
        /// <summary>
        /// Количество абитуриентов на заочном обучении
        /// </summary>
        double СorrespondenceCount { get; }
        /// <summary>
        /// Количество баллов по математике у абитуриентов
        /// </summary>
        double MathCount { get; }
        /// <summary>
        /// Количество баллов по русскому языку у абитуриентов
        /// </summary>
        double RussianCount { get; }
        /// <summary>
        /// Количество баллов по информатике у абитуриентов
        /// </summary>
        double ComputerScienceCount { get; }
        /// <summary>
        /// Общее количество баллов у абитуриентов за все экзамены
        /// </summary>
        double TotalScoreCount { get; }
    }
}
