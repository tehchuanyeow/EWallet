﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EWallet_API.Controllers
{
    public class PermissionsController : ApiController
    {
        // GET: api/Permissions
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Permissions/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Permissions
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Permissions/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Permissions/5
        public void Delete(int id)
        {
        }
    }
}
