using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3;
using WebApplication3.Models;

namespace SDE3_job_WebHit_ReturnJson_Test
{
    [TestFixture]
    public class WebHitManager_test
    {
        [Test]
        public void Test_LastVisitedPage_WhenNull_ReturnsNull()
        {
            // Arrange.
            List<Hit> HiltList = null;
            DateTime yesterday = DateTime.Now;
            List<User> UserList = null;
            WebHitManager wHitManager = new WebHitManager();

            // Act.
            var LastVisitedPage = wHitManager.LastVisitedPage(HiltList, UserList, yesterday);


            //Assert
            Assert.That(LastVisitedPage, Is.Null, "There should Not be any data for the LastVisitedPage");
        }
        [Test]
        public void Test_LastVisitedPage_WhenCorrectParameter_ReturnsCollection()
        {
            // Arrange.
            List<Hit> HiltList;
            DateTime yesterday;
            List<User> UserList;
            WebHitManager wHitManager = new WebHitManager();
            DAL.IntiData(out HiltList, out yesterday, out UserList);

            // Act.
            var LastVisitedPage = wHitManager.LastVisitedPage(HiltList, UserList, yesterday);


            //Assert
            Assert.That(LastVisitedPage, Is.Not.Null, "There should be some data for the LastVisitedPage");
        }
        [Test]
        public void Test_TopTenMostActiveUsers_WhenNull_ReturnsNull()
        {
            // Arrange.
            List<Hit> HiltList = null;
            DateTime yesterday = DateTime.Now;
            List<User> UserList = null;
            WebHitManager wHitManager = new WebHitManager();

            // Act.
            var TopTenMostActiveUsers = wHitManager.TopTenMostActiveUsers(HiltList, UserList, yesterday);


            //Assert
            Assert.That(TopTenMostActiveUsers, Is.Null, "There should Not be any data for the TopTenMostActiveUsers");
        }
        [Test]
        public void Test_TopTenMostActiveUsers_WhenCorrectParameter_ReturnsCollection()
        {
            // Arrange.
            List<Hit> HiltList;
            DateTime yesterday;
            List<User> UserList;
            WebHitManager wHitManager = new WebHitManager();
            DAL.IntiData(out HiltList, out yesterday, out UserList);

            // Act.
            var TopTenMostActiveUsers = wHitManager.TopTenMostActiveUsers(HiltList, UserList, yesterday);


            //Assert
            Assert.That(TopTenMostActiveUsers, Is.Not.Null, "There should be some data for the TopTenMostActiveUsers");
        }

    }
}