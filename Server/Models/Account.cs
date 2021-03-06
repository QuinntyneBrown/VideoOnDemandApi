﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoOnDemandApi.Server.Models
{
    public class Account : BaseEntity
    {
        public Account()
        {
            this.Profiles = new HashSet<Profile>();
        }

        public string Name { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }

        [ForeignKey("DefaultProfile")]
        public int DefaultProfileId { get; set; }

        public ICollection<Profile> Profiles { get; set; }

        public Profile DefaultProfile { get; set; }

        public User User { get; set; }

    }
}
