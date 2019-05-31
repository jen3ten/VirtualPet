using System;
using Xunit;
using VirtualPet;

namespace VirtualPet.Tests
{
    public class OrganicTests
    {
        [Fact]
        public void FeedShouldLowerHungerByOne()
        {
            string fakeName = "";
            string fakeSpecies = "";
            Organic sut = new Organic(fakeName, fakeSpecies);
            sut.FeedPet();                       
            Assert.Equal(49, sut.Hunger);
        }
    }
}
