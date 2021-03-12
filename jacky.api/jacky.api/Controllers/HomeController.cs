using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jacky.api.Controllers
{
    [Area("api/jacky")]
    [ApiController]
    public class HomeController : Controller
    {
        [HttpPost("show-index")]
        public String Index()
        {
            return "Hello world!";
        }
    }
}
