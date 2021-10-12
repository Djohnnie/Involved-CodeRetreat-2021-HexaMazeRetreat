using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace HexaMazeRetreat.Blazor.Helpers
{
    public static class EmbeddedResourceHelper
    {
        public static string GetLevelByResourceName(string resourceName)
        {
            try
            {
                using var stream = typeof(EmbeddedResourceHelper).GetTypeInfo()
                    .Assembly.GetManifestResourceStream(resourceName);
                using var reader = new StreamReader(stream, Encoding.UTF8);
                return reader.ReadToEnd();
            }

            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        public static Stream GetGraphicsByResourceName(string resourceName)
        {
            return typeof(EmbeddedResourceHelper).GetTypeInfo()
                .Assembly.GetManifestResourceStream(resourceName);
        }
    }
}