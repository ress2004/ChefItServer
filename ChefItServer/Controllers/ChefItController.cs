using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChefItServerBL.Models;

namespace ChefItServer.Controllers
{
    [Route("ChefItAPI")]
    [ApiController]
    public class ChefItController : ControllerBase
    {
        ChefItDBContext context;
        public ChefItController(ChefItDBContext context)
        {
            this.context = context;
        }

        [Route("Test")]
        [HttpGet]
        public string Test()
        {
            return "Hello Magic World!";
        }
    }
}
