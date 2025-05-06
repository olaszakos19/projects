using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Data;
using Models;

namespace UserTests
{
    [TestClass]
    public class UserHandlerTest
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
        public void AddUser()
        {
            var users = new List<User>();
            var mockSet = new Mock<DbSet<User>>();
            mockSet.Setup(m => m.Add(It.IsAny<User>())).Callback<User>(u => users.Add(u));

            var mockContext = new Mock<DataContext>();
            mockContext.Setup(m => m.Users).Returns(mockSet.Object);
            mockContext.Setup(m => m.SaveChanges()).Returns(1);

            var handler = new UserHandler(mockContext.Object);
            var newUser = new User { FirstName = "Test", LastName = "User", Email = "test@test.com", Password = "pw" };

            var result = handler.AddUser(newUser);

            Assert.AreEqual("User added succesfully", result);
            Assert.AreEqual(1, users.Count);
            Assert.AreEqual("Test", users[0].FirstName);
        }

        [TestMethod]
        public void DeleteUser()
        {
            var user = new User { Id = 1 };
            var users = new List<User> { user };
            var mockSet = new Mock<DbSet<User>>();
            mockSet.Setup(m => m.Remove(It.IsAny<User>())).Callback<User>(u => users.Remove(u));

            var mockContext = new Mock<DataContext>();
            mockContext.Setup(m => m.Users).Returns(mockSet.Object);
            mockContext.Setup(m => m.SaveChanges()).Returns(1);

            var handler = new UserHandler(mockContext.Object);
            var result = handler.RemoveUser(user);

            Assert.AreEqual("User deleted succesfully", result);
            Assert.AreEqual(0, users.Count);
        }

        [TestMethod]
        public void UpdateUser()
        {
            var existingUser = new User { Id = 1, FirstName = "Old", LastName = "Name", Email = "old@mail.com", Password = "123" };
            var updatedUser = new User { Id = 1, FirstName = "New", LastName = "Name", Email = "new@mail.com", Password = "abc" };
            var users = new List<User> { existingUser };

            var mockSet = GetMockDbSet(users);

            var mockContext = new Mock<DataContext>();
            mockContext.Setup(m => m.Users).Returns(mockSet.Object);
            mockContext.Setup(m => m.SaveChanges()).Returns(1);

            var handler = new UserHandler(mockContext.Object);
            var result = handler.UpdateUser(updatedUser);

            Assert.AreEqual("User updated succesfully", result);
            Assert.AreEqual("New", existingUser.FirstName);
            Assert.AreEqual("new@mail.com", existingUser.Email);
        }

        [TestMethod]
        public void GetOnlyUsers()
        {
            var users = new List<User>
        {
            new User { Id = 1, isAdmin = false },
            new User { Id = 2, isAdmin = true }
        };

            var mockSet = GetMockDbSet(users);
            var mockContext = new Mock<DataContext>();
            mockContext.Setup(m => m.Users).Returns(mockSet.Object);

            var handler = new UserHandler(mockContext.Object);
            var result = handler.GetOnlyUsers();

            Assert.AreEqual(1, result.Count);
            Assert.IsFalse(result.First().isAdmin);
        }

        [TestMethod]
        public void Login_True()
        {
            var user = new User { Email = "test@mail.com", Password = "123" };
            var users = new List<User> { user };

            var mockSet = GetMockDbSet(users);
            var mockContext = new Mock<DataContext>();
            mockContext.Setup(m => m.Users).Returns(mockSet.Object);

            var handler = new UserHandler(mockContext.Object);
            var result = handler.Login(new User { Email = "test@mail.com", Password = "123" });

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Login_False()
        {
            var users = new List<User>(); // no user

            var mockSet = GetMockDbSet(users);
            var mockContext = new Mock<DataContext>();
            mockContext.Setup(m => m.Users).Returns(mockSet.Object);

            var handler = new UserHandler(mockContext.Object);
            var result = handler.Login(new User { Email = "test@mail.com", Password = "123" });

            Assert.IsFalse(result);
        }
    }

}
