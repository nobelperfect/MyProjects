using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3
{
    public class WebHitManager
    {
        public List<Hit> LastVisitedPage(List<Hit> HiltList, List<User> UserList, DateTime date)
        {

            if (HiltList == null || UserList == null)
                return null;
            var allLastVisitedPage = HiltList.Where(hit => UserList.Any(user => user.Id.Equals(hit.UserId) && hit.Date.Equals(date)));

            List<Hit> ActiveUser = new List<Hit>();
            foreach (var obj in allLastVisitedPage)
            {
                ActiveUser.Add(obj);
            }
            return ActiveUser;

        }
        public List<object> TopTenMostActiveUsers(List<Hit> HiltList, List<User> UserList, DateTime date,int NumberOfRecored=10)
        {
            if (HiltList == null || UserList == null)
                return null;

            var topTenMostActiveUsers =
               (from user in UserList
                group user by new
                {
                    FirstName = user.FirstName,
                    HowManyVisit = HiltList.Where(hit => hit.Date.Equals(date)).Count(n => n.UserId.Equals(user.Id))
                } into userGroup
                orderby userGroup.Key.HowManyVisit descending
                select userGroup).Take(NumberOfRecored);
            List<object> ActiveUser = new List<object>();
            foreach (var obj in topTenMostActiveUsers)
            {
                ActiveUser.Add(obj.Key);
            }

            return ActiveUser;
        }
    }
}