namespace ClassLibrary
{

    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }

    public class Triangle : Shape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public override double GetArea()
        {
            double halfP = (_sideA + _sideB + _sideC) / 2.0;
            //since we do not check for existing of an actual triangle this is going to throw an exception for results where halfP is going to be less than a side length
            //for example result for input sides 3, 5, 15 is going to be an exception that we do not handle since such triangle cannot exist
            return Math.Sqrt(halfP * (halfP - _sideA) * (halfP - _sideB) * (halfP - _sideC));
        }

        public Boolean isRight()
        {
            double squareA = _sideA * _sideA;
            double squareB = _sideB * _sideB;
            double squareC = _sideC * _sideC;
            return squareA + squareB == squareC || squareA + squareC == squareB || squareB + squareC == squareA;
        }
    }

}