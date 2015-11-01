using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StartFromScratch.Controllers
{
    public class ValuesController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] {"v1","v2" };
        }

        public string Get(int id)
        {
            return "valueT";
        }
    }
}
