using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreapi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;


namespace coreapi.Middleware
{
    public class custommiddleware
    {
		private readonly RequestDelegate _next;
		private readonly ILogger<custommiddleware> _logger;


		public custommiddleware(RequestDelegate next,IMail mail, ILogger<custommiddleware> logger)
		{
			_next = next;
			_logger = logger;
		}

		public async Task Invoke(HttpContext context,IMail mail)
		{
			_logger.LogInformation(context.Request.Body.ToString());
			mail.Sendmail(context.Request.Body.ToString());
			await _next(context);
		}
	}
}
