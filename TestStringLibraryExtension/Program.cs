using UtilityLibraries;

namespace TestStringLibraryExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "hello";

            Console.WriteLine($"Is {word} uppercase? The answer is: {word.StartsWithUpper()}");
        }
    }
}
