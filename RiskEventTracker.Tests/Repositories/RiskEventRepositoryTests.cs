using RiskEventTracker.API.Models;
using RiskEventTracker.API.Repositories;

namespace RiskEventTracker.Tests.Repositories
{
    public class RiskEventRepositoryTests
    {
        private readonly RiskEventRepository _repository;

        public RiskEventRepositoryTests()
        {
            _repository = new RiskEventRepository();
        }

        [Fact]
        public void Add_ShouldStoreRiskEvent()
        {
            // Arrange
            var riskEvent = new RiskEvent
            {
                Title = "Test Event",
                Description = "Testing add functionality",
                Type = "Operational Risk",
                Severity = "Low"
            };

            // Act
            _repository.Add(riskEvent);

            // Assert
            var result = _repository.GetById(riskEvent.Id);
            Assert.NotNull(result);
            Assert.Equal("Test Event", result.Title);
        }

        [Fact]
        public void Update_ShouldModifyRiskEvent()
        {
            // Arrange
            var riskEvent = new RiskEvent
            {
                Title = "Original",
                Description = "Original description",
                Type = "Cyber Risk",
                Severity = "Medium"
            };
            _repository.Add(riskEvent);

            var updated = new RiskEvent
            {
                Id = riskEvent.Id, // important
                Title = "Updated",
                Description = "Updated description",
                Type = "Cyber Risk",
                Severity = "Critical"
            };

            // Act
            _repository.Update(updated);

            // Assert
            var result = _repository.GetById(riskEvent.Id);
            Assert.Equal("Updated", result.Title);
            Assert.Equal("Critical", result.Severity);
        }

        [Fact]
        public void Delete_ShouldRemoveRiskEvent()
        {
            // Arrange
            var riskEvent = new RiskEvent
            {
                Title = "To be deleted",
                Description = "Delete test",
                Type = "Market Risk",
                Severity = "High"
            };
            _repository.Add(riskEvent);

            // Act
            _repository.Delete(riskEvent.Id);

            // Assert
            var result = _repository.GetById(riskEvent.Id);
            Assert.Null(result);
        }
    }
}