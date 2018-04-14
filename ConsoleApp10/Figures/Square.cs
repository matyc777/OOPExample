namespace OOPExample
{
    class Square : Figure
    {
        double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override double area()
        {
            return side * side;
        }

        public override string ToString()
        {
            return string.Format("Square, {0}", area());
        }
    }
}
