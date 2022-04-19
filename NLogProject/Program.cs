using System;
namespace NLogProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello This Is A NLog Demo");
            AddNumbers numbers = new AddNumbers();
            numbers.Sum(1, 2);
        }
    }
}