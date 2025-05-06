using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Data;
using Models;

namespace BannedTest
{
    [TestClass]
    public class BannedHandlerTest
    {
        private Mock<DbSet<T>> GetMockDbSet<T>(List<T> sourceList) where T : class
        {
            var queryable = sourceList.AsQueryable();

            var mockSet = new Mock<DbSet<T>>();
            mockSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
            mockSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
            mockSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            mockSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(() => queryable.GetEnumerator());

            return mockSet;
        }


        [TestMethod]
        public void BanVehicle()
        {
            // Arrange
            var vehicle = new Vehicle { LicensePlate = "XYZ123" };
            var parkingLot = new Parkinglot { Id = 1, Name = "Test Lot" };
            var banned = new Banned { vehicle = vehicle, parkinglot = parkingLot };

            var mockSet = new Mock<DbSet<Banned>>();
            var mockContext = new Mock<DataContext>();
            mockContext.Setup(m => m.BannedList).Returns(mockSet.Object);

            var handler = new BannedHandler(mockContext.Object);

            // Act
            var result = handler.BanVehicle(banned);

            // Assert
            mockSet.Verify(m => m.Add(It.Is<Banned>(b => b.vehicle == vehicle && b.parkinglot == parkingLot)), Times.Once);
            mockContext.Verify(m => m.SaveChanges(), Times.Once);
            Assert.IsTrue(result.Contains("XYZ123"));
        }

        [TestMethod]
        public void UnBanVehicle()
        {
            // Arrange
            var vehicle = new Vehicle { LicensePlate = "XYZ123" };
            var parkingLot = new Parkinglot { Id = 1, Name = "Test Lot" };
            var banned = new Banned { vehicle = vehicle, parkinglot = parkingLot };

            var mockSet = new Mock<DbSet<Banned>>();
            var mockContext = new Mock<DataContext>();
            mockContext.Setup(m => m.BannedList).Returns(mockSet.Object);

            var handler = new BannedHandler(mockContext.Object);

            // Act
            var result = handler.UnBanVehicle(banned);

            // Assert
            mockSet.Verify(m => m.Remove(It.Is<Banned>(b => b.vehicle == vehicle && b.parkinglot == parkingLot)), Times.Once);
            mockContext.Verify(m => m.SaveChanges(), Times.Once);
            Assert.IsTrue(result.Contains("unbanned"));
        }

        [TestMethod]
        public void GetBannedVehicles()
        {
            // Arrange
            var lot = new Parkinglot { Id = 1, Name = "Lot A" };

            var data = new List<Banned>
            {
                new Banned { vehicle = new Vehicle { LicensePlate = "A1" }, parkinglot = lot },
                new Banned { vehicle = new Vehicle { LicensePlate = "B2" }, parkinglot = new Parkinglot { Id = 2 } }
            };

            var mockSet = GetMockDbSet(data);

            var mockContext = new Mock<DataContext>();
            mockContext.Setup(m => m.BannedList).Returns(mockSet.Object);

            var handler = new BannedHandler(mockContext.Object);

            // Act
            var result = handler.BannedVehiclesInLot(lot);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("A1", result[0].vehicle.LicensePlate);
        }

    }
}
