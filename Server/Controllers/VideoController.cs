using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace VideoOnDemandApi.Server.Controllers
{
    [RoutePrefix("api/video")]
    public class VideoController : ApiController
    {
        [HttpGet]
        [Route("test")]
        public string Test()
        {
            return "test";
        }
    }
}
