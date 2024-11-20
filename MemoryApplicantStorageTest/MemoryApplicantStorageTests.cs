using System;
using System.Linq;
using System.Threading.Tasks;
using DataGridView.Standart.Contracts.Interfaces;
using DataGridView.Standart.Contracts.Models;
using FluentAssertions;
using Xunit;

namespace DataGridView.Standart.Memory.Tests
{
    /// <summary>
    /// Тесты для класса <see cref="MemoryApplicantStorage"/>
    /// </summary>
    public class MemoryApplicantStorageTests
    {
        private readonly IApplicantStorage applicantStorage;

        /// <summary>
        /// Инициализирует новый экземпляр тестового класса
        /// </summary>
        public MemoryApplicantStorageTests()
        {
            applicantStorage = new MemoryApplicantStorage();
        }

        /// <summary>
        /// Тест на добавление записи в хранилище
        /// </summary>
        [Fact]
        public async Task AddAsync_ShouldAddApplicantToStorage()
        {
            // Arrange
            var applicant = new Applicant
            {
                Id = Guid.NewGuid(),
                Name = "Test Applicant",
                Gender = Gender.Male,
                Birthday = DateTime.Now.AddYears(-20),
                Education = Education.FullTimePartTime,
                Math = 75,
                Russian = 85,
                ComputerScience = 90,
                TotalScore = 250
            };

            // Act
            var result = await applicantStorage.AddAsync(applicant);

            // Assert
            result.Should().BeEquivalentTo(applicant);

            var allApplicants = await applicantStorage.GetAllAsync();
            allApplicants.Should().ContainSingle()
                .Which.Should().BeEquivalentTo(applicant);
        }

        /// <summary>
        /// Тест на удаление записи из хранилища
        /// </summary>
        [Fact]
        public async Task DeleteAsync_ShouldRemoveApplicantFromStorage()
        {
            // Arrange
            var applicant = new Applicant
            {
                Id = Guid.NewGuid(),
                Name = "Test Applicant",
                Gender = Gender.Female,
                Birthday = DateTime.Now.AddYears(-25),
                Education = Education.FullTimePartTime,
                Math = 80,
                Russian = 75,
                ComputerScience = 85,
                TotalScore = 240
            };

            await applicantStorage.AddAsync(applicant);

            // Act
            var deleteResult = await applicantStorage.DeleteAsync(applicant.Id);

            // Assert
            deleteResult.Should().BeTrue();

            var allApplicants = await applicantStorage.GetAllAsync();
            allApplicants.Should().BeEmpty();
        }

        /// <summary>
        /// Тест на редактирование записи в хранилище
        /// </summary>
        [Fact]
        public async Task EditAsync_ShouldUpdateApplicantInStorage()
        {
            // Arrange
            var applicant = new Applicant
            {
                Id = Guid.NewGuid(),
                Name = "Initial Name",
                Gender = Gender.Male,
                Birthday = DateTime.Now.AddYears(-30),
                Education = Education.FullTimePartTime,
                Math = 70,
                Russian = 80,
                ComputerScience = 85,
                TotalScore = 235
            };

            await applicantStorage.AddAsync(applicant);

            var updatedApplicant = new Applicant
            {
                Id = applicant.Id,
                Name = "Updated Name",
                Gender = Gender.Female,
                Birthday = applicant.Birthday,
                Education = Education.FullTimePartTime,
                Math = 95,
                Russian = 90,
                ComputerScience = 100,
                TotalScore = 285
            };

            // Act
            await applicantStorage.EditAsync(updatedApplicant);

            // Assert
            var allApplicants = await applicantStorage.GetAllAsync();
            allApplicants.Should().ContainSingle()
                .Which.Should().BeEquivalentTo(updatedApplicant);
        }
        // <summary>
        /// При пустом списке нет ошибок <see cref="IApplicantStorage.GetAllAsync"/>
        /// </summary>
        [Fact]
        public async Task GetAllAsyncShouldNotThrow()
        {
            // Act
            Func<Task> act = () => applicantStorage.GetAllAsync();

            // Assert
            await act.Should().NotThrowAsync();
        }

        /// <summary>
        /// Получает пустой список <see cref="IApplicantStorage.GetAllAsync"/>
        /// </summary>
        [Fact]
        public async Task GetAllAsyncShouldReturnEmpty()
        {
            // Act
            var result = await applicantStorage.GetAllAsync();

            // Assert
            result.Should()
                .NotBeNull()
                .And.BeEmpty();
        }

    }
}