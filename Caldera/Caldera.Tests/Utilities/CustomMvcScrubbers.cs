using System.Text.RegularExpressions;

namespace Caldera.Tests.Utilities
{
    public class CustomMvcScrubbers
    {
        public static string CopyrightScrubber(string input)
        {
            string copyrightTag = @"<p>&copy; \d{4}";
            return Regex.Replace(input, copyrightTag, "<p>&copy; 0000");
        }
    }
}
