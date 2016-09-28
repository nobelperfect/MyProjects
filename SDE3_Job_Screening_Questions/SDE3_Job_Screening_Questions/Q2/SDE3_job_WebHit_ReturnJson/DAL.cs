using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3
{
    public class DAL
    {
        public static void IntiData(out List<Hit> HiltList, out DateTime yesterday, out List<User> UserList)
        {
            Guid guid_1 = Guid.Parse("18f28962-c275-459e-8ae7-9ce0d9548dba");
            Guid guid_2 = Guid.Parse("18f28962-c275-459e-8ae7-9ce0d9548dbb");
            Guid guid_3 = Guid.Parse("18f28962-c275-459e-8ae7-9ce0d9548dbc");
            Guid guid_4 = Guid.Parse("18f28962-c275-459e-8ae7-9ce0d9548dbd");

            yesterday = DateTime.Now.AddDays(-1).Date;

            HiltList = new List<Hit>();
            HiltList.Add(new Hit { Date = DateTime.Now, Id = Guid.NewGuid(), UserId = guid_1, Url = "google.com" });
            HiltList.Add(new Hit { Date = yesterday, Id = Guid.NewGuid(), UserId = guid_1, Url = "yahoo.com" });
            HiltList.Add(new Hit { Date = yesterday, Id = Guid.NewGuid(), UserId = guid_2, Url = "microsofe.com" });
            HiltList.Add(new Hit { Date = yesterday, Id = Guid.NewGuid(), UserId = guid_3, Url = "apple.com" });
            HiltList.Add(new Hit { Date = yesterday, Id = Guid.NewGuid(), UserId = guid_4, Url = "hotmail.com" });
            HiltList.Add(new Hit { Date = yesterday, Id = Guid.NewGuid(), UserId = guid_4, Url = "hotmail.com" });
            HiltList.Add(new Hit { Date = yesterday, Id = Guid.NewGuid(), UserId = guid_4, Url = "hotmail.com" });
            HiltList.Add(new Hit { Date = yesterday, Id = Guid.NewGuid(), UserId = guid_4, Url = "hotmail.com" });
            HiltList.Add(new Hit { Date = yesterday, Id = Guid.NewGuid(), UserId = guid_4, Url = "hotmail.com" });
            HiltList.Add(new Hit { Date = DateTime.Now.AddDays(-2), Id = Guid.NewGuid(), UserId = guid_3, Url = "amazon.com" });
            HiltList.Add(new Hit { Date = DateTime.Now.AddDays(-3), Id = Guid.NewGuid(), UserId = guid_4, Url = "ibm.com" });

            UserList = new List<User>();
            UserList.Add(new User { FirstName = "Fitsum", Id = guid_1 });
            UserList.Add(new User { FirstName = "Nati", Id = guid_2 });
            UserList.Add(new User { FirstName = "Yonu", Id = guid_3 });
            UserList.Add(new User { FirstName = "Brook", Id = guid_4 });
        }
    }
}