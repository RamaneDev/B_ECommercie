using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace B_ECommercie.MWs
{
    public class ExceptionMW
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMW> _logger;
        private readonly IHostEnvironment _env;

        public ExceptionMW(RequestDelegate next, ILogger<ExceptionMW> logger, IHostEnvironment env)
        {
            _next = next;
            _logger = logger;
            _env = env;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);           
            } 
            catch (Exception ex)
            {

            }
        }
    }

    public static class MyMiddlewareExtensions
    {
        public static IApplicationBuilder UseExcetionMW(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ExceptionMW>();
        }
    }

     
}
