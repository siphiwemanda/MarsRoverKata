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
        [Fact]
        public void WhenMovingXMinus11XIs9()
        {
            //Arrange
            var grid = new Grid();
            //Act
            grid.Move(-11, 0);
            //Assert
            Assert.Equal(9, grid.X);
        }
        [Fact]
        public void WhenMovingYMinus11YIs9()
        {
            //Arrange
            var grid = new Grid();
            //Act
            grid.Move(0, -11);
            //Assert
            Assert.Equal(9, grid.Y);
        }
        [Fact]
        public void WhenMovingYPlus11YIs1()
        {
            //Arrange
            var grid = new Grid();
            //Act
            grid.Move(0, 11);
            //Assert
            Assert.Equal(1, grid.Y);
        }
        [Fact]
        public void WhenMovingYMinus21YIs9()
        {
            //Arrange
            var grid = new Grid();
            //Act
            grid.Move(0, -21);
            //Assert
            Assert.Equal(9, grid.Y);
        }
        [Fact]
        public void WhenMovingXMinus30XIs0()
        {
            //Arrange
            var grid = new Grid();
            //Act
            grid.Move(-30, 0);
            //Assert
            Assert.Equal(0, grid.X);
        }
        [Fact]
        public void WhenMovingYPlus25YIs5()
        {
            //Arrange
            var grid = new Grid();
            //Act
            grid.Move(0, 25);
            //Assert
            Assert.Equal(5, grid.Y);
        }
    }
}