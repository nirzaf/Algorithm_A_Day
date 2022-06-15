
using Algorithm_A_Day.DesignOnes;
using Xunit;

namespace Algorith_A_Day.Tests.DesignOnes
{
    public class DesignParkingSystemLc1603ETests
    {
        private DesignParkingSystemLc1603E _sut;

        public DesignParkingSystemLc1603ETests()
        {
            _sut = new DesignParkingSystemLc1603E(1, 1, 0);
        }

        [Fact]
        public void AddCar_ReturnsFalse_WhenThereIsRoomNoLeftForAnotherBigCar()
        {
            //Arrange
            _sut.AddCar(1);
            _sut.AddCar(2);
            _sut.AddCar(3);
            //Act
            var actual = _sut.AddCar(1);
            //Assert
            Assert.False(actual);
        }
        
        [Fact]
        public void AddCar_ReturnsTrue_WhenAllCarHaveRoom()
        {
            //Arrange
            _sut = new DesignParkingSystemLc1603E(1, 1, 1);
            
            //Act
            var actualSmall = _sut.AddCar(1);
            var actualMedium = _sut.AddCar(2);
            var actualBig = _sut.AddCar(3);
            //Assert
            Assert.True(actualSmall);
            Assert.True(actualMedium);
            Assert.True(actualBig);
        }
        
        [Fact]
        public void AddCar_ReturnsTrue_WhenNoRoomForCarsAtBeginning()
        {
            //Arrange
            _sut = new DesignParkingSystemLc1603E(0, 0, 0);
            
            //Act
            var actualSmall = _sut.AddCar(1);
            var actualMedium = _sut.AddCar(2);
            var actualBig = _sut.AddCar(3);
            //Assert
            Assert.False(actualSmall);
            Assert.False(actualMedium);
            Assert.False(actualBig);
        }
    }
}
