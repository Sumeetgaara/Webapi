using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreapi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreapi.Controllers
{
    [Produces("application/json")]
    [Route("api/Blog")]
    public class BlogController : Controller
    {
		private readonly BloggingContext _context;
		public BlogController(BloggingContext context)
		{
			_context = context;
		}
		// GET api/values
		[HttpGet]
		public IEnumerable<Blog> Get()
		{
			return _context.Blog.ToList();

		}
	}
}