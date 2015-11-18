using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoOnDemandApi.Server.Data;
using VideoOnDemandApi.Server.Models;
using System.Data.Entity.Migrations;

namespace VideoOnDemandApi.Migrations
{
    public class UserConfiguration
    {
        public static void Seed(VideoOnDemandContext context)
        {
            var user = new User()
            {
                Id = 1,
                Username = "qbrown",
                Password = "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=",
                Firstname = "Quinn",
                Lastname = "Brown"
            };

            context.Users.AddOrUpdate(user);

            context.SaveChanges();
        }
    }
}