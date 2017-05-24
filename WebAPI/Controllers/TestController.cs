using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Produces("application/json")]
  
    public class TestController : Controller
    {

        [HttpGet]
        [Route("Mobile/Gcap/test")]

        public IEnumerable<string> TestMethod()
        {
            return new string[] { "Success" };
        }




    }
}