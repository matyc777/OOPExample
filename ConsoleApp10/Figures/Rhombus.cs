using System;

namespace OOPExample
{
    class Rhombus : Figure
    {
        double side;
        int angle;

        public Rhombus(double side, int angle)
        {
            this.side = side;
            this.angle = angle;
        }

        public override double area()
        {
            return 2 * side * Math.Abs(Math.Sin(angle));
        }

        public override string ToString()
        {
            return string.Format("Rhombus, {0}", area());
        }
    }
}
