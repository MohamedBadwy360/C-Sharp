using System.Text;

namespace _02_EncodingAndUnicode
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Unicode is a standard for encoding, representing, and handling text in most of the world's writing systems.
            // Unicode is a superset of ASCII and Latin-1.
            // Unicode is a 21-bit character set, which means it can represent 2^21 characters.
            // Unicode is a character set, not an encoding.

            // UTF-8, UTF-16, and UTF-32 are encodings of Unicode.
            // UTF-8 is the most popular encoding of Unicode.
            // UTF-8 is a variable-length encoding, which means it uses 1 to 4 bytes to represent a character.
            // UTF-8 is backward compatible with ASCII.

            // UTF-16 is a fixed-length encoding, which means it uses 2 bytes to represent a character.
            // UTF-16 is used by Windows and Java.
            // UTF-16 is backward compatible with ASCII.

            // UTF-32 is a fixed-length encoding, which means it uses 4 bytes to represent a character.
            // UTF-32 is used by Unix and Linux.
            // UTF-32 is backward compatible with ASCII.

            // C# uses UTF-16 to represent strings.
            // C# uses System.Text.Encoding class to convert strings to bytes and vice versa.

            // Encoding is the process of converting a string to a byte array.
            // Decoding is the process of converting a byte array to a string.

            // ASCII is a 7-bit character set, which means it can represent 2^7 characters.
            // ASCII is a character set, not an encoding.
            // ASCII is a subset of Unicode.

            // ASCII encoding uses 1 byte to represent a character.
            // ASCII encoding is backward compatible with UTF-8.

            // Encoding.ASCII.GetBytes() method converts a string to a byte array using ASCII encoding.
            // Encoding.ASCII.GetString() method converts a byte array to a string using ASCII encoding.

            // Encoding.UTF8.GetBytes() method converts a string to a byte array using UTF-8 encoding.
            // Encoding.UTF8.GetString() method converts a byte array to a string using UTF-8 encoding.

            // -------------------------------------------------------------------------------------------

            await GetDataUtf8Format();

            Console.ReadKey();
        }

        static async Task GetDataAssciFormat()
        {
            var path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}";
            var filePath = $"{path}\\asciiNewsContent.txt";

            using (var client = new HttpClient())
            {
                Uri uri = new Uri("https://aljazeera.net/search/feed");
                using (HttpResponseMessage response = await client.GetAsync(uri))
                {
                    var byteArray = await response.Content.ReadAsByteArrayAsync();
                    string result = Encoding.ASCII.GetString(byteArray);
                    File.WriteAllText(filePath, result);
                }
            }
        }

        static async Task GetDataUtf8Format()
        {
            var path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}";
            var filePath = $"{path}\\asciiNewsContent.txt";

            using (var httpClient = new HttpClient())
            {
                Uri uri = new Uri("https://aljazeera.net/search/feed");
                using (HttpResponseMessage response = await httpClient.GetAsync(uri))
                {
                    var byteArray = await response.Content.ReadAsByteArrayAsync();
                    string result = Encoding.UTF8.GetString(byteArray);

                    File.WriteAllText(filePath, result);
                }
            }

        }
    }
}
