using System;

namespace _01
{
    class Program
    {

        static void Main(string[] args)
        {

        }
        public static string Capitalize(string source) 
        {
            string result = "";
            char ch = source[0];
            int charToIntAscii = ((int)ch) - 32;
            char AsciiToBigLetter = (char)charToIntAscii;
            result += AsciiToBigLetter;

            for (int i = 1; i < source.Length; i++)
            {
                result += source[i];
            }
            return result;
        }
    }
}
