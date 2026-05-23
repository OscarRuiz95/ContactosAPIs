namespace Contactos.SI.Middleware
{
    public class ApiKeyMiddleware
    {
        private readonly RequestDelegate _next;
        private const string APIKEY = "X-API-KEY";

        public ApiKeyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IConfiguration config)
        {
            if (!context.Request.Headers.TryGetValue(APIKEY, out var apiKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("API Key requerida");
                return;
            }

            var key = config["ApiKey"];

            if (!key.Equals(apiKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("API Key inválida");
                return;
            }

            await _next(context);
        }
    }
}
