﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hello_world.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello","World"} ;
        }
    }
}

