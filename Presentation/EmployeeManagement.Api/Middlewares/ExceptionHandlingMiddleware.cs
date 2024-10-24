using Microsoft.AspNetCore.Diagnostics;
using System.Net;
using System.Net.Mime;
using System.Text.Json;

namespace EmployeeManagement.Api.Middlewares
{
    public static class ExceptionHandlingMiddleware
    {
        public static void ConfigureExceptionHandler<T>(this WebApplication application, ILogger<T> logger)
        {
            application.UseExceptionHandler(builder =>
            {
                builder.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = MediaTypeNames.Application.Json;

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        var errorId = Guid.NewGuid().ToString();

                        logger.LogError($"Error ID: {errorId}, Message: {contextFeature.Error.Message}");

                        var response = new
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = contextFeature.Error.Message,
                            ErrorId = errorId, 
                            Title = "An error occurred"
                        };

                        var options = new JsonSerializerOptions
                        {
                            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                            WriteIndented = true
                        };

                        await context.Response.WriteAsync(JsonSerializer.Serialize(response, options));
                    }
                });
            });
        }
    }
}
