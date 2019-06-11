using System;

namespace Strings_Ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenString = "SOLID priciples were first introduced by Michael Feathers.";
            char givenChar = 'p';
            TransformToLowercase(givenString, givenChar);
        }
        //Write a method that transforms to lowercase first n characters in a string
        public static string TransformToLowercase(string input, char count)
        {
            string result = string.Empty;
            // aBCdef 
            // n = 3
            // abc

            result = input.Substring(0, count).ToLower();

            result += input.Substring(count + 1);

            return result;
        }
    }
}
