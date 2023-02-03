using ClassLibrary;

Shape circle = new Circle(12.4);
//double a = 3.4;
//double b = 15;
//double c = 5;
//Shape triangle = new Triangle(a, b, c);

//Shape triangle = new Triangle(2, 100, 99);
Triangle triangle = new Triangle(3, 4, 5);

//double p = (a + b + c) / 2;
//double squqareTimesTwo = p * Math.Abs(p - a) * Math.Abs(p - b) * Math.Abs(p - c);

Console.WriteLine(circle.GetArea().ToString("#.#####"));
//Console.WriteLine(p);
//Console.WriteLine(squqareTimesTwo);
Console.WriteLine(triangle.GetArea().ToString("#.#####"));
Console.WriteLine(triangle.isRight().ToString());
