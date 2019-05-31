using System;
using Xunit;
using VirtualPet;

namespace VirtualPet.Tests
{
    public class RoboticTests
    {
        [Fact]
        public void OilShouldIncreaseOilLevelByOne()
        {
            string fakeName = "";
            string fakeSpecies = "";
            Robotic sut = new Robotic(fakeName, fakeSpecies);
            sut.OilPet();
            Assert.Equal(51, sut.OilLevel);
        }
        [Fact]
        public void PlayWithPetShouldDecreaseBoredomAndIncreasePerformanceLevelByOneEach()
        {
            string fakeName = "";
            string fakeSpecies = "";
            Robotic sut = new Robotic(fakeName, fakeSpecies);
            sut.PlayWithPet();
            Assert.Equal(49, sut.Boredom);
            Assert.Equal(76, sut.PerformanceLevel);
        }
    }
}
