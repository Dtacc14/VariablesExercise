using System;

namespace VariablesExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myCat = "Toeny";

            int catsToes = 28;

            char confusion = '?';

            bool polydactyly = true;

            double vetVisits = 2.7;

            decimal toeConversations = 99.999m;

            Console.WriteLine($"My cat {myCat} has {catsToes} toes. You may be thinking {catsToes} toes{confusion} Well, it's because {myCat} is is a polydactyly.");
            Console.WriteLine($"It is {polydactyly} {myCat} has that many toes.");
            Console.WriteLine($"This makes us have to go to the vet quite often. Usually about {vetVisits} times a month to get his paws trimmed.");
            Console.WriteLine($"We also usually have about {toeConversations} coversations about his toes when we bring him in.");
        }
    }
}
