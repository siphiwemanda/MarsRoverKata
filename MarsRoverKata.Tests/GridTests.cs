using Xunit;

namespace MarsRoverKata.Tests
{
    public class GridTests
    {
        [Fact]
        public void WhenMovingYMinus2YIs8()
        {
            //Arrange
            var grid = new Grid();
            //Act
            grid.Move(0, -2);
            //Assert
            Assert.Equal(8, grid.Y);
        }
        [Fact]
        public void WhenMovingXMinus2XIs8()
        {
            //Arrange
            var grid = new Grid();
            //Act
            grid.Move(-2, 0);
            //Assert
            Assert.Equal(8, grid.X);
        }
        [Fact]
        public void WhenMovingYPlus2YIs2()
        {
            //Arrange
            var grid = new Grid();
            //Act
            grid.Move(0, 2);
            //Assert
            Assert.Equal(2, grid.Y);
        }
        [Fact]
        public void WhenMovingXPlus2XIs2()
        {
            //Arrange
            var grid = new Grid();
            //Act
            grid.Move(2, 0);
            //Assert
            Assert.Equal(2, grid.X);
        }
        [Fact]
        public void WhenMovingXPlus11XIs1()
        {
            //Arrange
            var grid = new Grid();
            //Act
            grid.Move(11, 0);
            //Assert
            Assert.Equal(1, grid.X);
        }
    }
}