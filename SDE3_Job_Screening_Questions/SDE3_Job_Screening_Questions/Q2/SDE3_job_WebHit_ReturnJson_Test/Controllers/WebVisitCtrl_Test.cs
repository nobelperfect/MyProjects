using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using WebApplication3.Controllers;
using WebApplication3.Models;

namespace SDE3_job_WebHit_ReturnJson_Test
{
    [TestFixture]
    public class WebVisitCtrl_Test
    {
        [Test]

        public void Test_GetTopTenMostActiveUsers_WhenCorrect_ReturnsCollection()
        {
            // Arrange.
            List<Result> expected = new List<Result>();
            expected.Add(new Result() { FirstName = "Brook", HowManyVisit = 5 });
            expected.Add(new Result() { FirstName = "Fitsum", HowManyVisit = 1 });
            expected.Add(new Result() { FirstName = "Nati", HowManyVisit = 1 });
            expected.Add(new Result() { FirstName = "Yonu", HowManyVisit = 1 });
            WebVisitController _controller = new WebVisitController();

            // Act.
            var jsonResult = _controller.GetTopTenMostActiveUsers();
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Result> result = serializer.Deserialize<List<Result>>(serializer.Serialize(jsonResult));

            //Assert
            Assert.That(result, Is.Not.Null, "There should be some data for the Result");
            Assert.That(result, Is.EqualTo(expected));



        }
    }
}