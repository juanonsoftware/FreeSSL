namespace EasyFreeSSLSite
{
    public static class HttpRequestExtensions
    {
        public static string GetCurrentUrl(this HttpRequest request)
        {
            return $"{request.Scheme}://{request.Host}{request.PathBase}{request.Path}{request.QueryString}";
        }
    }
}