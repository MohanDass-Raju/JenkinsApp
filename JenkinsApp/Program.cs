using System;
using MyMaths;

namespace JenkinsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Welcome to jenkins");
            
            Maths m = new Maths();
            int ares = m.Add(5, 4);
            int mres = m.Mul(2, 4);
            Console.WriteLine(ares + " is addition");
            Console.WriteLine(mres + "is multipication");
            Console.ReadLine();
        }
    }
}
