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
        [Fact]
        public void SendPing_ReturnsSuccessMessage() // Omitting class name as it's implied by the test project structure
        {
            // Arrange
            var networkService = new NetworkService();

            // Act
            var result = networkService.SendPing();

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
    }
}
