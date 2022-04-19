using System;
using Model;

namespace Lesson11_Polymorphism
{
    public static class Program
    {
        const int animalCount = 4;
        const int shapeCount = 4;

        static void Main(string[] args)
        {
            Console.WriteLine("What to draw - Shape/Animal ???");
            string input = Console.ReadLine();

            if((input == "Shape") || (input == "shape"))
            {
                Shape[] shapes = new Shape[shapeCount];
                for (int i = 0; i < shapeCount; i++)
                {
                    var color = GetRandomNumber(0, 14);
                    var dotColor = GetRandomNumber(0, 14);
                    Shape shape;
                    if (i < 2)
                    {
                        shape = new Circle($"Circle {i + 1}", color, "0", dotColor);
                    }
                    else
                    {
                        shape = new Square($"Square {i + 1}", color, "0", dotColor);
                    }
                    shapes[i] = shape;

                }

                foreach (var shape in shapes)
                {
                    shape.Rander();
                }


            }
            else if ((input == "Animal") || (input == "animal"))
            {
                Animal[] animals = new Animal[animalCount];

                for (int i = 0; i < animalCount; i++)
                {
                    var eyeColor = GetRandomNumber(0, 14);
                    var catColor = GetRandomNumber(0, 14);
                    Animal animal;
                    if (i < 2)
                    {
                        animal = new Cat("Vaska " + i, '0', eyeColor, catColor);
                    }
                    else
                    {
                        animal = new Dog("Sharik " + i, '0', eyeColor, catColor);
                    }
                    animals[i] = animal;
                }

                foreach (var animal in animals)
                {
                    animal.Render();
                }

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("ERROR");
            }

        }

        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }
    }
}
