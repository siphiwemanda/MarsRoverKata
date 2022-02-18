using Xunit;

namespace MarsRoverKata.Tests
{
    public class ObstacleTests
    {
        [Fact]
        public void Roverhitsobsitcal()
        {
            //Arrange
            var obstacleRepo = new ObstacleRepo();
            obstacleRepo.AddObstacle(0, 1);
            var grid = new Grid(obstacleRepo);
            //Act
            grid.Move(0, 1);
            //Assert
            Assert.Equal(0, grid.Y);
        }

        [Fact]
        public void ARoverIsAtZeroZeroSouthWhenInitialized()
        {
            //Arrange
            var rover = new Rover();
            //Act
            var position = rover.Execute("");
            //Assert
            //Assert
            Assert.Equal("0:0:S", position);

        }
    }
}