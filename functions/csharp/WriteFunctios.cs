using System;

namespace csharp
{
    static class WriteFunctions
    {
        public static void Write(string name)
        {
            Console.WriteLine(string.Concat("Your name is: ", name));
        }
    }
}