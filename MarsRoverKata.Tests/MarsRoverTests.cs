using Xunit;

namespace MarsRoverKata.Tests
{
    public class MarsRoverTests
    {
        #region RotateTest
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

        [Fact]
        public void ARoverPointsSouthAfterTheCommandRRRR()
        {
            //Arrange
            var rover = new Rover();
            //Act
            var position = rover.Execute("RRRR");
            //Assert
            Assert.Equal("0:0:S", position);
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
        public void ARoverPointsNorthAfterTheCommandLL()
        {
            //Arrange
            var rover = new Rover();
            //Act
            var position = rover.Execute("LL");
            //Assert
            Assert.Equal("0:0:N", position);
        }

        [Fact]
        public void ARoverPointsWestAfterTheCommandLLL()
        {
            //Arrange
            var rover = new Rover();
            //Act
            var position = rover.Execute("LLL");
            //Assert
            Assert.Equal("0:0:W", position);
        }

        [Fact]
        public void ARoverPointsSouthAfterTheCommandLLLL()
        {
            //Arrange
            var rover = new Rover();
            //Act
            var position = rover.Execute("LLLL");
            //Assert
            Assert.Equal("0:0:S", position);
        }
        #endregion

        [Fact]
        public void ARoverMovesForwardOneSpaceWhenFacingSouth()
        {
            //Arrange
            var rover = new Rover();
            //Act
            var position = rover.Execute("M");
            //Assert
            Assert.Equal("0:1:S", position);
        }
        [Fact]
        public void ARoverMovesForwardOneSpaceWhenFacingEast()
        {
            //Arrange
            var rover = new Rover();
            //Act
            var position = rover.Execute("LM");
            //Assert
            Assert.Equal("1:0:E", position);
        }
        [Fact]
        public void ARoverMovesForwardFourSpaceWhenFacingEast()
        {
            //Arrange
            var rover = new Rover();
            //Act
            var position = rover.Execute("LMMMM");
            //Assert
            Assert.Equal("4:0:E", position);
        }
        
        [Fact]
        public void ARoverMovesForwardFourSpaceWhenFacingWest()
        {
            //Arrange
            var rover = new Rover();
            //Act
            var position = rover.Execute("LMMMMLLMMMM");
            //Assert
            Assert.Equal("0:0:W", position);
        }
        [Fact]
        public void ARoverMovesWillMoveNorthWhenFacingNorth()
        {
            //Arrange
            var rover = new Rover();
            //Act
            var position = rover.Execute("MLLM");
            //Assert
            Assert.Equal("0:0:N", position);
        }
        [Fact]
        public void ARoverLoopToTheOtherSideOfTheGridWhenMovingNorth()
        {
            //Arrange
            var rover = new Rover();
            //Act
            var position = rover.Execute("LLM");
            //Assert
            Assert.Equal("0:9:N", position);
        }
        [Fact]
        public void ARoverLoopToTheOtherSideOfTheGridWhenMovingWest()
        {
            //Arrange
            var rover = new Rover();
            //Act
            var position = rover.Execute("RM");
            //Assert
            Assert.Equal("9:0:W", position);
        }
    }
}
