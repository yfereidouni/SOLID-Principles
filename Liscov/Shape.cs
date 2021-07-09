using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liscov
{
    public abstract class Shape
    {
        public string Name { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public abstract double Environment();

        public abstract double Area();

        public abstract string DisplayDetails();
    }
    
    public class Triangle : Shape
    {
        public Triangle(string name,int width, int height)
        {
            this.Name = name;

            this.Width = width;

            this.Height = height;
        }

        public override double Area() => (Height * Width) / 2;

        public override double Environment() => Width * 3;
        
        public override string DisplayDetails() => string.Format($"{Name} | Area: {Area()} | Environment: {Environment()}");
    }

    public class Squre : Shape
    {
        public Squre(string name, int width, int height)
        {
            this.Name = name;

            this.Width = width;

            this.Height = height;
        }

        public override double Area() => Width * Width;

        public override double Environment() => Width * 4;

        public override string DisplayDetails() => string.Format($"{Name} | Area: {Area()} | Environment: {Environment()}");
    }

    public class Rectangle : Shape
    {
        public Rectangle(string name, int width, int height)
        {
            this.Name = name;

            this.Width = width;

            this.Height = height;
        }

        public override double Area()=> Width * Height;

        public override double Environment()=> (Width + Height) * 2;

        public override string DisplayDetails() => string.Format($"{Name} | Area: {Area()} | Environment: {Environment()}");
    }
}