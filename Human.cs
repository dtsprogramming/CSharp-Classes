using System;

namespace CreatingClasses
{
    internal class Human
    {
        private string firstName = "FName";
        private string lastName = "LName";
        private string eyeColor = "Color";
        private int age = 0;

        // Default constructor (no values).
        public Human()
        {
            Console.WriteLine("Constructor called. Default Human object");
        }

        // Default constructor (optional values).
        public Human(string firstName = "FName", string lastName = "LName",
            string eyeColor = "Color", int age = 0)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public void Introduction()
        {
            string plural = CheckAge();

            Console.WriteLine($"Hi, my name is {firstName} {lastName}. I am {age} {plural} old, " +
                $"and I have {eyeColor} eyes.");
        }

        private string CheckAge() => (age == 1) ? "year" : "years";
    }
}
