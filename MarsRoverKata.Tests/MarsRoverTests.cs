using Xunit;

namespace MarsRoverKata.Tests
{
    public class MarsRoverTests
    {
        [Fact]
        public void ARoverIsAtZeroZeroSouthWhenInitialized()
        {
            //Arrange
            var rover = new Rover();
            //Act
            var position = rover.Execute("");
            //Assert
            Assert.Equal("0:0:S", position);
        }
        //[Fact]
        // public void ARoverMovesOnePositionWhenRecivingTheCommandM()
        // {
        //     //Arrange
        //     var rover = new Rover();
        //     //Act
        //     var position = rover.Execute("M");
        //     //Assert
        //     Assert.Equal("0:1:S", position);
        // }
        [Fact]
        public void ARoverPointsWestAfterTheCommandR()
        {
            //Arrange
            var rover = new Rover();
            //Act
            var position = rover.Execute("R");
            //Assert
            Assert.Equal("0:0:W", position);
        }
        [Fact]
        public void ARoverPointsEastAfterTheCommandL()
        {
            //Arrange
            var rover = new Rover();
            //Act
            var position = rover.Execute("L");
            //Assert
            Assert.Equal("0:0:E", position);
        }
        [Fact]
        public void ARoverPointsNorthAfterTheCommandRR()
        {
            //Arrange
            var rover = new Rover();
            //Act
            var position = rover.Execute("RR");
            //Assert
            Assert.Equal("0:0:N", position);
        }
        [Fact]
        public void ARoverPointsEastAfterTheCommandRRR()
        {
            //Arrange
            var rover = new Rover();
            //Act
            var position = rover.Execute("RRR");
            //Assert
            Assert.Equal("0:0:E", position);
        }
    }
}
