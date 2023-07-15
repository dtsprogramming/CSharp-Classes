using System;

namespace CreatingClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Human Instances.
            Human bot = new Human();
            Human tim = new Human("Timmy", "Hans", "Blue", 34);

            // Box Instances
            Box smBox = new Box(2, 2, 2);
            Box lgBox = new Box(10, 24, 14);

            // Calls to public class methods.
            IntroduceHumans(bot, tim);
            BuildABox(smBox, lgBox);


            // Wait for key input so console can be read.
            Console.ReadKey();
        }

        #region BOX
        private static void BuildABox(params Box[] boxes)
        {
            int count = 1;

            foreach (Box box in boxes)
            {
                Console.WriteLine($"Box {count}:");
                box.BoxValues();
                count++;
            };
        }
        #endregion

        #region HUMAN
        private static void IntroduceHumans(params Human[] humans)
        {
            foreach (Human human in humans)
            {
                human.Introduction();
            }
        }
        #endregion
    }
}
