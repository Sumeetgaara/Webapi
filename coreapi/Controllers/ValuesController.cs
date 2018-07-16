using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using coreapi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace coreapi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
		private readonly BloggingContext _context;
		public ValuesController(BloggingContext context)
		{
			_context = context;
		}
		// GET api/values
		[HttpGet]
		public IEnumerable<Blog> Get()
		{
			return _context.Blog.ToList();

		}

		// GET api/values/5
		[HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
