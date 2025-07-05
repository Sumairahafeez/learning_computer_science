using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Circle
    {
        private double Radius=1;
        private string Color="RED";
        public Circle() { }
        public Circle(double radius, string color)
        {
            this.Radius = radius;
            this.Color = color;
        }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double GetRadius()
        {
            return this.Radius;
        }
        public void SetRadius(double radius)
        {
               this.Radius=radius;
        }
        public string GetColor()
        {
            return this.Color;
        }
        public void SetColor(string color)
        { this.Color = color; }
        public double GetArea()
        {
            double Area = (Radius * Radius) * (22 / 7);
            return Area;
        }
        public string ToString()
        {
            return "Circle[Radius = "+ Radius.ToString()+" color = " + Color+" ]";
        }
    }
}
