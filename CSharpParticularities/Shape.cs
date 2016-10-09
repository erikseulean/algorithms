using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParticularities
{
    public abstract class Shape
    {
        public double Area { get; private set; }

        public abstract double CalculateArea();
        public Shape()
        {
            Area = CalculateArea();
        }
    }

    public class Square : Shape
    {
        private double length;

        public Square(double len) : base()
        {
            this.length = len;
        }

        public override double CalculateArea()
        {
            return length * length;
        }
    }
}
