using System;

namespace CreatingClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human bot = new Human();
            Human tim = new Human("Timmy", "Hans", "Blue", 34);

            bot.Introduction();
            tim.Introduction();

            Console.ReadKey();
        }
    }
}
