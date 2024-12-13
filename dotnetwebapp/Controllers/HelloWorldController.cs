using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace dotnetwebapp.Controllers
{
    public class HelloWorldController : ApiController
    {
        [HttpGet]
        public string Index()
        {
            return "Hello World!";
        }
    }
}