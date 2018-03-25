using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MoqExample;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class BandControllerTest
    {
        [TestMethod]
        public void MethodToTest()
        {
            // Arange
            var listOfBands = new List<Band>();

            listOfBands.Add(new Band {
                Name = "Rush",
                Origin = "Toronto, Canada",
                Genre = "ProgRock",
                BestSong = "Red Barchetta"
            });


            Mock<IRepository> mockRepository = new Mock<IRepository>();
            mockRepository.Setup(x => x.GetBands()).Returns(listOfBands);

            // Act
            var bandController = new BandController(mockRepository.Object);
            bandController.MethodToTest();

            // Assert fluid
            bandController.Should().NotBeNull();
            listOfBands.Count.Should().Be(1);
            listOfBands[0].Name.Should().Be("Rush");

            // Assert standard
            Assert.IsNotNull(bandController);
            Assert.AreEqual(expected: 1, actual: listOfBands.Count);
            Assert.AreEqual(expected: "Rush", actual: listOfBands[0].Name);
        }
    }
}
