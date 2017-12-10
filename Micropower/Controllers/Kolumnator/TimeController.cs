using Micropower.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Micropower.Controllers
{
    public class TimeController : ApiController
    {
        // GET: api/Time
        public string Get()
        {
            DateTimeProvider timeprovider = new DateTimeProvider();

            return "$time^"+timeprovider.GetDateTime().ToLongTimeString()+"#";
        }

        // GET: api/Time/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Time
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Time/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Time/5
        public void Delete(int id)
        {
        }
    }
}
