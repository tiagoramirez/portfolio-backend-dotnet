using Microsoft.EntityFrameworkCore;
using portfolio.Helpers;

namespace portfolio.Middlewares;

public class EditDeleteMiddleware
{
    readonly RequestDelegate next;

    public EditDeleteMiddleware(RequestDelegate nextRequest)
    {
        next = nextRequest;
    }

    public async Task Invoke(HttpContext context, PortfolioContext dbContext)
    {
        var reqAuth = context.Request.Headers.FirstOrDefault(h => h.Key == "Authorization");

        if (reqAuth.Key == null)
        {
            await next(context);
        }
        else
        {
            string auth = reqAuth.Value;

            if (await dbContext.Users.AnyAsync(u => u.Id == JwtHelper.GetId(auth) && u.Username == JwtHelper.GetUsername(auth)))
            {
                await next(context);
            }
        }
    }
}

public static class EditDeleteMiddlewareExtension
{
    public static IApplicationBuilder UseEditDeleteMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<EditDeleteMiddleware>();
    }
}