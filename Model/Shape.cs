using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Shape
    {
        protected int color;
        protected string name;
        protected string obj;
        protected int dotColor;
        public Shape(string name, int color = 10, string obj = "0", int dotColor = 3)
        {
            this.color = color;
            this.name = name;
            this.obj = obj;
            this.dotColor = dotColor;
        }
        public virtual void Rander()
        {
            Console.WriteLine("I't is Shape");
        }
    }
}
