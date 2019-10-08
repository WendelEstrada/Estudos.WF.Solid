using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Estudos.WF.Solid.Service.WebApi.Controllers
{
    public class LutadorController : ApiController
    {
        // GET: api/Lutador
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Lutador/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Lutador
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Lutador/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Lutador/5
        public void Delete(int id)
        {
        }
    }
}
