using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZwajApp.API.Data;

namespace ZwajApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _Context;
        public ValuesController(DataContext Context)
        {
            _Context = Context;

        }
        // GET api/values
        [HttpGet]
        public IActionResult GetValues()
        {
            var value=_Context.Values.ToList();
            return Ok(value);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetValues(int id)
        {
            var value=_Context.Values.FirstOrDefault(a=>a.id==id);
            return Ok(value);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
