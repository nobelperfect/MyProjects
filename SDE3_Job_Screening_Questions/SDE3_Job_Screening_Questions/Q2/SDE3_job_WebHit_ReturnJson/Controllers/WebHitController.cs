using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class WebHitController : ApiController
    {
      
        public IEnumerable<object> GetAllLastVisitedPage()
        {
            List<Hit> HiltList;
            DateTime yesterday;
            List<User> UserList;

            //Data initialization 
            DAL.IntiData(out HiltList, out yesterday, out UserList);

            WebHitManager wHitManager = new WebHitManager();
            var AllLastVisitedPage = wHitManager.LastVisitedPage(HiltList, UserList, yesterday);


            return AllLastVisitedPage; 
        }


       

    }



}
