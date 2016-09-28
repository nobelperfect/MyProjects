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
    public class WebHitCtrl_Test
    {
          [Test]
          public void Test_GetAllLastVisitedPage_WhenCorrect_ReturnsCollection()
          {
              // Arrange.
              Guid guid_1 =Guid.Parse("18f28962-c275-459e-8ae7-9ce0d9548dba");
              Guid guid_2 =Guid.Parse("18f28962-c275-459e-8ae7-9ce0d9548dbb");
              Guid guid_3 =Guid.Parse("18f28962-c275-459e-8ae7-9ce0d9548dbc");
              Guid guid_4 =Guid.Parse("18f28962-c275-459e-8ae7-9ce0d9548dbd");
              var yesterday = DateTime.Now.AddDays(-1).Date;

              List<Hit> expected = new List<Hit>();

              expected.Add(new Hit { Date = yesterday, Id = Guid.NewGuid(), UserId = guid_1, Url = "yahoo.com" });
              expected.Add(new Hit { Date = yesterday, Id = Guid.NewGuid(), UserId = guid_2, Url = "microsofe.com" });
              expected.Add(new Hit { Date = yesterday, Id = Guid.NewGuid(), UserId = guid_3, Url = "apple.com" });
              expected.Add(new Hit { Date = yesterday, Id = Guid.NewGuid(), UserId = guid_4, Url = "hotmail.com" });
              expected.Add(new Hit { Date = yesterday, Id = Guid.NewGuid(), UserId = guid_4, Url = "hotmail.com" });
              expected.Add(new Hit { Date = yesterday, Id = Guid.NewGuid(), UserId = guid_4, Url = "hotmail.com" });
              expected.Add(new Hit { Date = yesterday, Id = Guid.NewGuid(), UserId = guid_4, Url = "hotmail.com" });
              expected.Add(new Hit { Date = yesterday, Id = Guid.NewGuid(), UserId = guid_4, Url = "hotmail.com" });



              WebHitController _controller = new WebHitController();

              // Act.
              var result = _controller.GetAllLastVisitedPage();

              //Assert
              Assert.That(result, Is.Not.Null, "There should be some data for the Result");
              Assert.That(result, Is.EqualTo(expected));



          }
    }
}