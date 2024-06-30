namespace _29_Attributes
{
    public class UpdateProcessor
    {
        // The Obsolete attribute is used to mark a method that is no longer in use.
        // The Obsolete attribute is used to inform the compiler that a method is obsolete.
        // The Obsolete attribute is used to generate a warning or an error when a method is called.
        // The Obsolete attribute is defined in the System namespace.
        // error variable is used to specify whether the compiler should generate a warning or an error when a method is called.
        // if the error variable is set to true, the compiler generates an error when a method is called.
        // if the error variable is set to false, the compiler generates a warning when a method is called.
        // message variable is used to specify a message that is displayed when a method is called.
        [Obsolete("This method is obsolete. Use DownloadAndInstall method instead.", false)]
        public static void Download(Update[] updates)
        {
            foreach (var update in updates)
            {
                Console.WriteLine($"Downloading - {update}");
            }
        }

        [Obsolete("This method is obsolete. Use DownloadAndInstall method instead.", true)]
        public static void Install(Update[] updates)
        {
            foreach (var update in updates)
            {
                Console.WriteLine($"Installing - {update}");
            }
        }

        public static void DownloadAndInstall(Update[] updates)
        {
            foreach (var update in updates)
            {
                Console.WriteLine($"Downloading - {update}");
                Console.WriteLine($"Installing - {update}");
            }
        }
    }
}
