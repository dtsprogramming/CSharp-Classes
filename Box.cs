using System;

namespace CreatingClasses
{
    internal class Box
    {
        private int length;
        private int width;
        private int height;
        private int volume;

        public Box(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public void BoxValues()
        {
            volume = CalculateBoxVolume();

            Console.WriteLine($"Length: {length}\nWidth: {width}\n" +
                $"Height: {height}\nVolume: {volume}\n");
        }

        private int CalculateBoxVolume()
        {
            return length * width * height;
        }
    }
}
