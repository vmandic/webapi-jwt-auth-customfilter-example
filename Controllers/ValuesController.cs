using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using authtest.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace authtest.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    {        
        [HttpGet("~/test1")]
        public string Test1()
        {
          return "works 1!";
        }

        [HttpGet("~/test2"), MyAuthorize]
        public string Test2()
        {
          return "works 2!";
        }

        [HttpGet("~/test3"), Authorize]
        public string Test3()
        {
          return "works 3!";
        }
    }
}
