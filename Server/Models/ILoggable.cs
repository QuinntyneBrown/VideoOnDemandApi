﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoOnDemandApi.Server.Models
{
    public interface ILoggable
    {
        DateTime? CreatedDate { get; set; }
        DateTime? LastModifiedDate { get; set; }
        string LastModifiedByUserName { get; set; }
        int? LastModifiedByUserId { get; set; }
    }
}
