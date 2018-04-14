namespace OOPExample
{
    class Circle : Figure
    {
        double Radius;
        
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public override double area()
        {
            return (Radius * Radius) * 3.14;
        }

        public override string ToString()
        {
            return string.Format("Circle, {0}", area());
        }
    }
}
