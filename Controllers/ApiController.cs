using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nrs;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace app.Controllers
{
    [Route("api/[controller]")]
    public class NrsController : Controller
    {
        // POST api/nrs
        [HttpPost]
        [Consumes("application/x-www-form-urlencoded")]
        public Nrs.NrsData Post([FromForm]Nrs.NrsData nrsData)
        {
            return nrsData;
        }
    }
}
