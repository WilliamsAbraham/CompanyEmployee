using CompanyEmployee.CustomExceptionMiddleware;
using Microsoft.AspNetCore.Builder;

namespace CompanyEmployee.Extensions
{
    public static class CustomExceptionMiddleWareExtention
    {
        public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
