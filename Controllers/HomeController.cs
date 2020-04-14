using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Http;

namespace Portfolio_1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]

        public string Home()
        {
            return "This is my index!";
        }

        [HttpGet("projects")]
        public string Projects()
        {
            return "These are my projects";
        }

        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my Contacts!";
        }
    }
}