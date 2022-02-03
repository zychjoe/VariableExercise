using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string partner = "Christina";
            int age = 28;
            char icon = '*';
            bool inLove = true;
            double relationshipLenYear = .9;
            decimal relationshipLenMo = 11.1m;


            Console.WriteLine($"Hi! my partner's name is {partner}. " +
                $"She is {age} years old. " +
                $"She is a {icon}! " +
                $"If people ask if we're in love, I say {inLove}! " +
                $"We have been together for {relationshipLenYear} years. " +
                $"Which is actually {relationshipLenMo} months. ");
        }
    }
}
