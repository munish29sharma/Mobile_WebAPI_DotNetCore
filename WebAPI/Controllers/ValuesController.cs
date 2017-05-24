using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using Microsoft.Extensions.Configuration;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebAPI.Reporsitory;

namespace WebAPI.Controllers
{
    //[Route("api/[controller]/[action]")]

    [Produces("application/json")]
    public class ValuesController : Controller
    {

        private IUserRepository userRepo = new UserRepository();

        [ActionName("Get")]
        [HttpGet]
        public JsonResult Get()
        {
            return Json(new string[] { "value1", "value2" });
        }

        [HttpGet]
        [Route("Mobile/Gcap/GetUserTable")]
        public JsonResult GetUserTable()
        {

            return Json(userRepo.GetUser());

        }


        [HttpGet]
        [Route("Mobile/Gcap/GetUserProc")]
        public JsonResult GetUserProc()
        {

             return Json(userRepo.GetUserProc());

        }
        
        [HttpGet]
        [Route("Mobile/Gcap/GetUserProject")]
        public JsonResult GetUserProject()
        {

            return Json(userRepo.GetUserProject());

        }


        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [ActionName("Post")]
        [HttpPost]
        public void Post([FromBody]string value)
        {


        }




    }
}
