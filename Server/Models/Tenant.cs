﻿using System.Collections.Generic;

namespace VideoOnDemandApi.Server.Models
{
    public class Tenant
    {
        public Tenant()
        {

        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
