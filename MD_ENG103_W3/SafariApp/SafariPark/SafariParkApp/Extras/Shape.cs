using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    //abstract classes can have both concrete & anbstract methods
    //Concrete classes cannot have abstract methods
    //Abstract methods MUST be implemented in their derived classes
    public abstract class Shape
    {

        //An abstract methods has a methods signature and no method body
        public abstract int CalculateArea();

        public override string ToString()
        {
            return $"{this.ToString()} and the area is {this.CalculateArea()}";
        }
    }

    //Derived classes must implement abstract methods from their base class
    public class Rectangle : Shape
    {
        private int _width;
        private int _height;

        public Rectangle(int height, int width)
        {
            _height = height;
            _width = width;
        }

        public override int CalculateArea()
        {
            return _height * _width;
        }
    }
}
