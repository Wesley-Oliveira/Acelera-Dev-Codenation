using Codenation.Challenge;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var states = new Country();
            var top = states.Top10StatesByArea();

            for(int i = 0; i < top.Length; i++)
            {
                Console.WriteLine(top[i].Name);
                Console.WriteLine(top[i].Acronym);
                Console.WriteLine(top[i].Area);
            }
            
            
        }
    }
}
