namespace _01_Ascii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ascii code is a 7-bit character set containing 128 characters.
            // It contains the numbers from 0-9, the upper and lower case English letters from A to Z, and some special characters.
            // The character sets used in modern computers, in HTML, and on the Internet, are all based on ASCII.
            // ASCII stands for American Standard Code for Information Interchange.
            // ASCII was developed in the 1960s and was published in 1967.
            // The ASCII code is a 7-bit code, meaning that it uses seven binary digits (bits) to represent each character.
            // Ascii code is a subset of Unicode.
            // Ascii code is used to represent text in computers, communications equipment, and other devices that use text.
            // Most modern character-encoding schemes are based on ASCII, although they support many more characters than did ASCII.
            // Ascii code is stored in 1 byte in hard disk.

            // The ascii of a character can be found by casting the character to int.
            // The character of an ascii can be found by casting the int to char.

            // Ascii code of 'A' is 65.

            // ------------------------------------------------------------------------------------------

            for (byte c = 0; c < 255; ++c)
            {
                char ch = (char)c;
                string dec = c.ToString().PadLeft(3, '0');
                string hex = c.ToString("X");
                string binary = Convert.ToString(c, 2).PadLeft(8, '0');
                Console.WriteLine($"{dec,-12} {binary,-12} {hex,-12} {ch,-12}");
            }

            Console.ReadKey();
        }
    }
}
