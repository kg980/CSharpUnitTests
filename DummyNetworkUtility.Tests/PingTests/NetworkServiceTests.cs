using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DummyNetworkUtility.Ping;
using FluentAssertions;
using Xunit;

namespace DummyNetworkUtility.Tests.PingTests
{
    public class NetworkServiceTests
    {
        private readonly NetworkService _networkService;
        public NetworkServiceTests() 
        {
            // SUT - System Under Test
            _networkService = new NetworkService();
        }

        [Fact]
        public void SendPing_ReturnsSuccessMessage() // Omitting class name as it's implied by the test project structure
        {
            // Arrange
            //var networkService = _networkService;

            // Act
            var result = _networkService.SendPing();

            // Assert
            //Assert.Equal("Success: Ping client", result);
                // Using FluentAssertions for more expressive assertions
                // should have a balance of strict enough that bugs dont fall through the cracks
                // but not too strict that other devs get annoyed and look for workarounds.
            result.Should().NotBeNullOrEmpty();
            result.Should().Be("Success: Ping client");
            result.Should().StartWith("Success");
            result.Should().Contain("Success", Exactly.Once());

        }

        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(5, 5, 10)]
        [InlineData(-1, 1, 0)]
        public void PingTimeout_ReturnsCorrectIntSum(int x, int y, int expectedSum)
        {
            // Arrange
            //var networkService = _networkService;

            // Act
            var result = _networkService.PingTimeout(x, y);

            // Assert
            result.Should().Be(expectedSum);
            result.Should().BeGreaterThanOrEqualTo(Math.Min(x, y));
            result.Should().BeGreaterThanOrEqualTo(0);
        }
    }
}
