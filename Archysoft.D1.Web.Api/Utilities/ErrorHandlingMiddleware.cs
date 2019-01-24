using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Archysoft.D1.Web.Api.Utilities
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _requestDelegate;

        public ErrorHandlingMiddleware()
        {

        }

        //protected virtual Task HandleExceptionAsync(HttpContext context, Exception exception)
        //{
        //    var model = JsonConvert.

        //    return context.Response.WriteAsync(model);
        //}

        protected virtual Task HandleUnauthorizedAssessException(HttpContext context)
        {

            return Task.FromResult(context);
        }
    }
}
