using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            string fileName = string.Empty;
            string fileExtension = string.Empty;

            int lastSeparatorOfIndex = filePath.LastIndexOf('\\');
            int ExtensionIndex = filePath.LastIndexOf('.');

            if (lastSeparatorOfIndex != -1 && ExtensionIndex != - 1 && lastSeparatorOfIndex < ExtensionIndex)
            {
                fileName = filePath.Substring(lastSeparatorOfIndex + 1, ExtensionIndex - lastSeparatorOfIndex - 1);
                fileExtension = filePath.Substring(ExtensionIndex + 1);
            }

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
