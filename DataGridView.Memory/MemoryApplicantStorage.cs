using DataGridView.Standart.Contracts.Interfaces;
using DataGridView.Standart.Contracts.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataGridView.Standart.Memory
{
    public class MemoryApplicantStorage : IApplicantStorage
    {
        private List<Applicant> people;

        public MemoryApplicantStorage()
        {
            people = new List<Applicant>();
        }

        public Task<Applicant> AddAsync(Applicant applicant)
        {
            people.Add(applicant);
            return Task.FromResult(applicant);
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            Applicant applicant = people.FirstOrDefault((Applicant x) => x.Id == id);
            if (applicant != null)
            {
                people.Remove(applicant);
                return Task.FromResult(result: true);
            }

            return Task.FromResult(result: false);
        }

        public Task EditAsync(Applicant applicant)
        {
            Applicant applicant2 = people.FirstOrDefault((Applicant x) => x.Id == applicant.Id);
            if (applicant != null)
            {
                applicant2.Name = applicant.Name;
                applicant2.Gender = applicant.Gender;
                applicant2.Birthday = applicant.Birthday;
                applicant2.Education = applicant.Education;
                applicant2.Math = applicant.Math;
                applicant2.Russian = applicant.Russian;
                applicant2.ComputerScience = applicant.ComputerScience;
                applicant2.TotalScore = applicant.TotalScore;
            }

            return Task.CompletedTask;
        }

        public Task<IReadOnlyCollection<Applicant>> GetAllAsync()
        {
            return Task.FromResult((IReadOnlyCollection<Applicant>)people);
        }
    }
}
