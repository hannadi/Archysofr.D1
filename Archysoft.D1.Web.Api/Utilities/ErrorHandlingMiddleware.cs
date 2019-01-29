using System;
using System.Net;
using System.Threading.Tasks;
using Archysoft.D1.Model.Exceptions;
using Archysoft.D1.Web.Api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Archysoft.D1.Web.Api.Utilities
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorHandlingMiddleware> _logger;

        public ErrorHandlingMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<ErrorHandlingMiddleware>();
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exepcion)
            {
                var exeptionType = exepcion.GetType();
                LogException(exeptionType, exepcion);

                if (exeptionType == typeof(UnauthorizedAccessException))
                {
                    await HandleUnauthorizedAssessException(context);
                }
                else
                {
                    await HandleExceptionAsync(context, exepcion);
                }
            }
        }

        protected virtual Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var response = new ApiResponse(-1, exception.Message);

            if (exception is BusinessException businessException)
            {
                response.Status = businessException.Status;
                response.Description = response.Description.Contains(nameof(BusinessException))
                    ? businessException.Description
                    : response.Description;
            }

            var model = JsonConvert.SerializeObject(response,
                new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });

            context.Response.ContentType = "application.json";
            context.Response.StatusCode = (int)HttpStatusCode.OK;

            return context.Response.WriteAsync(model);
        }

        protected virtual Task HandleUnauthorizedAssessException(HttpContext context)
        {
            context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;

            return Task.FromResult(0);
        }

        private void LogException(Type exceptionType, Exception exception)
        {
            if (exceptionType != typeof(BusinessException) && exceptionType != typeof(UnauthorizedAccessException))
            {
                _logger.LogError(exception, exception.Message);
            }
        }
    }
}
