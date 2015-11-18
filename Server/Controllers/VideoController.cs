using Common.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VideoOnDemandApi.Server.Data.Contracts;
using VideoOnDemandApi.Server.Models;

namespace VideoOnDemandApi.Server.Controllers
{
    [RoutePrefix("api/video")]
    public class VideoController : ApiController
    {
        public VideoController(IVideoOnDemandUow uow)
        {
            this.uow = uow;
            this.repository = uow.Videos;

        }
        [HttpGet]
        [Route("getFeatured")]
        public IHttpActionResult GetFeatured()
        {
            return Ok(this.repository.GetAll());
        }

        [HttpGet]
        [Route("add")]
        public IHttpActionResult Add(Video video)
        {
            this.repository.Add(video);
            this.uow.SaveChanges();
            return Ok(this.repository.GetAll());
        }

        [HttpPut]
        [Route("update")]
        public IHttpActionResult Update(Video video)
        {
            this.repository.Update(video);
            this.uow.SaveChanges();
            return Ok();
        }


        [HttpGet]
        [Route("remove")]
        public IHttpActionResult Remove(int id)
        {
            this.repository.Delete(id);
            this.uow.SaveChanges();
            return Ok();
        }

        protected IRepository<Video> repository;
        protected IVideoOnDemandUow uow;
    }
}
