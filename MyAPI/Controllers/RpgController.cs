using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RpgController : ControllerBase
    {
        [HttpGet]
        public RpgEntity Get()
        {
            RpgEntity result = null;

            result = new RpgEntity() { id = 0,name = "boss",lv = 999};
            return result;
        }
    }
}
