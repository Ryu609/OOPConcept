using System;

namespace OOP_Concept
{
    public class Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }

    internal class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
            base.Draw();
        }
    }

    internal class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
            base.Draw();
        }
    }
}