using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataGridView.Standart.Contracts.Interfaces;
using DataGridView.Standart.Contracts.Models;
using DataGridView.Standart.Manager;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace DataGridView.Manager.Tests
{
    /// <summary>
    /// Тесты для <see cref="ApplicantManager"/>
    /// </summary>
    public class ApplicantManagerTests
    {
        private readonly IApplicantManager applicantManager;
        private readonly Mock<IApplicantStorage> storageMock;
        private readonly Mock<ILogger> loggerMock;

        /// <summary>
        /// Инициализирует новый экземпляр тестового класса <see cref="ApplicantManagerTests"/>
        /// </summary>
        public ApplicantManagerTests()
        {
            storageMock = new Mock<IApplicantStorage>();

            loggerMock = new Mock<ILogger>();
            loggerMock.Setup(x => x.Log(LogLevel.Information,
                It.IsAny<EventId>(),
                It.IsAny<It.IsAnyType>(),
                null,
                It.IsAny<Func<It.IsAnyType, Exception, string>>()));

            applicantManager = new ApplicantManager(storageMock.Object, loggerMock.Object);
        }

        /// <summary>
        /// Тестирует метод <see cref="ApplicantManager.AddAsync(Applicant)"/>.
        /// </summary>
        [Fact]
        public async Task AddAsync_ShouldAdd()
        {
            // Arrange
            var testApplicant = new Applicant { Id = Guid.NewGuid(), Name = "Test Applicant" };
            storageMock.Setup(s => s.AddAsync((It.IsAny<Applicant>()))).ReturnsAsync(testApplicant);

            // Act
            var result = await applicantManager.AddAsync(testApplicant);

            // Assert
            result.Should().NotBeNull()
                .And.Be(testApplicant);

            loggerMock.Verify(x => x.Log
          (LogLevel.Information,
          It.IsAny<EventId>(),
          It.Is<It.IsAnyType>((state, t) => state.ToString().Contains(nameof(IApplicantManager.AddAsync))),
          null,
          It.IsAny<Func<It.IsAnyType, Exception, string>>()),
          Times.Once);
            loggerMock.VerifyNoOtherCalls();

            storageMock.Verify(x => x.AddAsync(It.Is<Applicant>(y => y.Id == testApplicant.Id)),
                Times.Once);
            storageMock.VerifyNoOtherCalls();
        }

        /// <summary>
        /// Тестирует метод <see cref="ApplicantManager.EditAsync"/> на успешное изменение данных.
        /// </summary>
        [Fact]
        public async Task EditAsync_ShouldLogAndEditApplicant()
        {
            // Arrange
            var testApplicant = new Applicant
            {
                Id = Guid.NewGuid(),
                Name = $"Name{Guid.NewGuid():N}",
                Gender = Gender.Male,
                Birthday = DateTime.Now,
                Education = Education.FullTime,
                Math = 52,
                Russian = 52,
                ComputerScience = 52,
            };
            storageMock.Setup(x => x.EditAsync(It.IsAny<Applicant>())).Returns(Task.CompletedTask);

            // Act
            await applicantManager.EditAsync(testApplicant);

            // Assert

            // Asset
            loggerMock.Verify(x => x.Log
            (LogLevel.Information,
            It.IsAny<EventId>(),
            It.Is<It.IsAnyType>((state, t) => state.ToString().Contains(nameof(IApplicantManager.EditAsync))),
            null,
            It.IsAny<Func<It.IsAnyType, Exception, string>>()),
            Times.Once);
            loggerMock.VerifyNoOtherCalls();

            storageMock.Verify(x => x.EditAsync(It.Is<Applicant>(y => y.Id == testApplicant.Id)),
                Times.Once);
            storageMock.VerifyNoOtherCalls();
        }


        /// <summary>
        /// Тестирует метод <see cref="ApplicantManager.DeleteAsync"/> на успешное удаление.
        /// </summary>
        [Fact]
        public async Task DeleteAsync_ShouldSuccessful()
        {
            // Arrange
            var testId = Guid.NewGuid();
            storageMock.Setup(s => s.DeleteAsync(testId)).ReturnsAsync(true);

            // Act
            var result = await applicantManager.DeleteAsync(testId);

            // Assert
            result.Should().BeTrue();

            loggerMock.Verify(x => x.Log
            (LogLevel.Information,
            It.IsAny<EventId>(),
            It.Is<It.IsAnyType>((state, t) => state.ToString().Contains(nameof(IApplicantManager.DeleteAsync))),
            null,
            It.IsAny<Func<It.IsAnyType, Exception, string>>()),
            Times.Once);
            loggerMock.VerifyNoOtherCalls();

            storageMock.Verify(x => x.DeleteAsync(testId),
                Times.Once);
            storageMock.VerifyNoOtherCalls();
        }

        /// <summary>
        /// Тестирует метод <see cref="ApplicantManager.GetStatsAsync"/> на успешное получение статистики по заявителям.
        /// </summary>
        [Fact]
        public async Task GetStatsAsync_ShouldApplicantsExist()
        {
            // Arrange
            var applicants = new List<Applicant>
            {
                new Applicant { Id = Guid.NewGuid(), Gender = Gender.Male, Education = Education.FullTime },
                new Applicant { Id = Guid.NewGuid(), Gender = Gender.Female, Education = Education.Сorrespondence }
            };
            storageMock.Setup(s => s.GetAllAsync()).ReturnsAsync(applicants);

            // Act
            var stats = await applicantManager.GetStatsAsync();

            // Assert
            stats.Should().NotBeNull();
            stats.MaleCount.Should().Be(1);
            stats.FemaleCount.Should().Be(1);
        }

        /// <summary>
        /// Тестирует метод <see cref="ApplicantManager.GetAllAsync"/> на успешное получение всех заявителей.
        /// </summary>
        [Fact]
        public async Task GetAllAsync_ShouldReturnApplicants_WhenSuccessful()
        {
            // Arrange
            var applicants = new List<Applicant>
            {
                new Applicant { Id = Guid.NewGuid(), Name = "Test Applicant 1" },
                new Applicant { Id = Guid.NewGuid(), Name = "Test Applicant 2" }
            };
            storageMock.Setup(s => s.GetAllAsync()).ReturnsAsync(applicants);

            // Act
            var result = await applicantManager.GetAllAsync();

            // Assert
            result.Should().NotBeNull()
                .And.HaveCount(applicants.Count)
                .And.BeEquivalentTo(applicants);

            storageMock.Verify(x => x.GetAllAsync(), Times.Once);
            storageMock.VerifyNoOtherCalls();
        }
    }
}
