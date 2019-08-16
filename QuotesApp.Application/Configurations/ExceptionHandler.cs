using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using QuotesApp.Domain.Exceptions;

namespace QuotesApp.Application.Configurations
{
    public class ExceptionHandler
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandler> _logger;

        public ExceptionHandler(RequestDelegate next, ILogger<ExceptionHandler> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            _logger.LogError($"Exception caught in the middleware.\n {exception}");

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            if (exception is AppBusinessException)
            {
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;

            }
            if (exception is AppNotFoundException)
            {
                context.Response.StatusCode = (int)HttpStatusCode.NotFound;

            }

            var error = new
            {
                Success = false,
                Code = context.Response.StatusCode,
                Message = exception.Message
            };

            return context.Response.WriteAsync(JsonConvert.SerializeObject(error));
        }

    }
}