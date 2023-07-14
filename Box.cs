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

        public int Volume
        {
            get => this.length * this.width * this.height;
            set { this.volume = value; }
        }

        public void BoxValues()
        {
            Console.WriteLine($"Length: {length}\nWidth: {width}\n" +
                $"Height: {height}\nVolume: {Volume}\n");
        }
    }
}
