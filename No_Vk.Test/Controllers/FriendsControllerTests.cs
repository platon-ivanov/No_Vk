﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using No_Vk.Domain.Controllers;
using No_Vk.Domain.Models;
using No_Vk.Domain.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace No_Vk.Test.Controllers
{
    public class FriendsControllerTests
    {
        private Mock<IUserRepository> _mockUserRepository = new();
        private Mock<ILogger<FriendsController>> _mockLogger = new();

        [Fact]
        public void AddFriend_EmailNotNullOrEmpty_ReturnDefaultView()
        {
            //Arrange
            FriendsController controller = new(_mockLogger.Object, _mockUserRepository.Object);
            string email = "";

            //Act 
             ViewResult result = controller.AddFriend(email) as ViewResult;

            //Assert
            Assert.Equal("AddFriend", result?.ViewName);
        }
        [Fact]
        public void AddFriend_IfFriendIsNull_ReturnDefaultView()
        {
            //Arrange
            FriendsController controller = new(_mockLogger.Object, _mockUserRepository.Object);
            string email = "invalid@email.pain";
            _mockUserRepository.Setup(repo => repo.GetUsers()).Returns(GetTestUsers());
            

            //Act 
            ViewResult result = controller.AddFriend(email) as ViewResult;

            //Assert
            Assert.Equal("AddFriend", result?.ViewName);
        }


        private IQueryable<User> GetTestUsers()
        {
            return new List<User>()
            {
                new() { Email = "1", Id = "12341243", Login = "log1", Password = "pass1", Role = RoleNames.Base.ToString() },
                new() { Email = "2", Id = "11231243", Login = "log2", Password = "pass2", Role = RoleNames.Base.ToString() },
                new() { Email = "3", Id = "13451243", Login = "log3", Password = "pass3", Role = RoleNames.Base.ToString() },
                new() { Email = "4", Id = "11223443", Login = "log4", Password = "pass4", Role = RoleNames.Base.ToString() },
                new() { Email = "5", Id = "34531243", Login = "log5", Password = "pass5", Role = RoleNames.Base.ToString() },
                new() { Email = "6", Id = "65673243", Login = "log6", Password = "pass6", Role = RoleNames.Base.ToString() }

            }.AsQueryable();
        }
    }
}
