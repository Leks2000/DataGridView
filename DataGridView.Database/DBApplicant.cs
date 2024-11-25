using DataGridView.Standart.Contracts.Interfaces;
using DataGridView.Standart.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DataGridView.Database
{
    /// <summary>
    /// Класс для работы контекста с бд аббитуриентов <see cref="DBApplicant"/>
    /// </summary>
    public class DBApplicant : IApplicantStorage
    {
        async Task<Applicant> IApplicantStorage.AddAsync(Applicant applicant)
        {
            using (var context = new DBApplicantContext())
            {
                var person = new Applicant
                {
                    Id = applicant.Id,
                    Name = applicant.Name,
                    Birthday = applicant.Birthday,
                    Education = applicant.Education,
                    Math = applicant.Math,
                    Russian = applicant.Russian,
                    ComputerScience = applicant.ComputerScience,
                };
                context.Applicants.Add(applicant);
                await context.SaveChangesAsync();
            }
            return applicant;
        }

        async Task<bool> IApplicantStorage.DeleteAsync(Guid id)
        {
            using (var context = new DBApplicantContext())
            {
                var applicant = await context.Applicants.FirstOrDefaultAsync(x => x.Id == id);
                if (applicant != null)
                {
                    context.Applicants.Remove(applicant);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            return false;
        }

        async Task IApplicantStorage.EditAsync(Applicant applicant)
        {
            using (var context = new DBApplicantContext())
            {
                var target = await context.Applicants.FirstOrDefaultAsync(x => x.Id == applicant.Id);
                if (target != null)
                {
                    target.Name = applicant.Name;
                    target.Gender = applicant.Gender;
                    target.Birthday = applicant.Birthday;
                    target.Education = applicant.Education;
                    target.Math = applicant.Math;
                    target.Russian = applicant.Russian;
                    target.ComputerScience = applicant.ComputerScience;
                }
                await context.SaveChangesAsync();
            }
        }

        async Task<IReadOnlyCollection<Applicant>> IApplicantStorage.GetAllAsync()
        {
            using(var context = new DBApplicantContext())
            {
                var items = await context.Applicants
                    .OrderByDescending(x => x.Name)
                    .ToListAsync();
                return items;
            }
        }
    }
}
