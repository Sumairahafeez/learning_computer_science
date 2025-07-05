using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Cylinder:Circle
    {
        private double Height=1.0;
        public Cylinder(double height)
        {
            Height = height;
        }
        public Cylinder() { }
        public Cylinder(double height,double Radius):base(Radius)
        {
            Height = height;
        }
        public Cylinder(double height, double Radius, string color):base(Radius, color)
        {
            Height = height;
        }
        public double GetHeight()
        {
            return Height;
        }
        public void SetHeight(double Height)
        {
            this.Height = Height;
        }
        public double GetVolume()
        {
            double vol = 0;
            vol = GetArea() * Height;
            return vol;
        }
    }
}
