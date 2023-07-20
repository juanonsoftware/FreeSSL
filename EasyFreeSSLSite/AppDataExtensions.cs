namespace EasyFreeSSLSite
{
    public static class AppDataExtensions
    {
        public static string ReadAppDataFile(this IWebHostEnvironment host, string fileName)
        {
            var appData = Path.Combine(host.ContentRootPath, "AppData");
            return File.ReadAllText(Path.Combine(appData, "IndexContent.html"));
        }
    }
}