using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAPI.Services;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RpgController : ControllerBase
    {
        private RpgService _service;

        public RpgController() //建構式construct
        {
            _service = new RpgService();
        }
        
        [HttpGet]
        [Route("{id}")]
        public RpgEntity Get(int id)
        {
            RpgEntity result = null;

            result = _service.Get(id);
            
            return result;
        }
        [HttpPost]
        public RpgEntity Post(RpgEntity rpgEntity)
        {
            RpgEntity result = null;

            result = _service.Create(rpgEntity);
            
            return result;
        }
    }
}
