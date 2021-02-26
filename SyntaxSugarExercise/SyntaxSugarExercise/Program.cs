using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            string response;

            {
                response = ( answer < 9) ?  " is less than nine" : "greater than or equal to nine";
            }
            
            Console.WriteLine($"{answer} {response}");

        }
    }
}
