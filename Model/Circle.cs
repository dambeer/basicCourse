using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Circle : Shape
    {
        public Circle(string name, int color, string obj, int dotColor) : base(name, color, obj, dotColor)
        {
        }

        public override void Rander()
        {
            var lines = 3;
            for(int i = 0; i < lines; i++)
            {
                Console.WriteLine();
            }
            var paddingLesft = "\t\t";
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(paddingLesft + @"   __");
            Console.WriteLine(paddingLesft + @" /    \");
            Console.Write(paddingLesft + @"|  ");
            Console.ForegroundColor = (ConsoleColor)dotColor;
            Console.Write($" {obj}");
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(@"  |");
            Console.WriteLine(paddingLesft + @" \ __ /");
            Console.WriteLine(paddingLesft + $"{name}");
        }
    }
}
