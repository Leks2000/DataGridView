using DataGridView.Standart.Contracts.Interfaces;
using FluentAssertions;
using System;
using System.Threading.Tasks;
using Xunit;

namespace DataGridView.Standart.Memory.Tests
{
    public class MemoryApplicantStorageTests
    {

        private readonly IApplicantStorage applicantStorage;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ApplicantStorageMemoryTests"/>
        /// </summary>

        [Fact]
        public async Task GetAllShouldGet()
        {
            // Act
            Func<Task> act = () => applicantStorage.GetAllAsync();

            // Assert
            await act.Should().NotThrowAsync();
        }

    }
}
