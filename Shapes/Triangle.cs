namespace Shapes
{
    public class Triangle : Shape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Стороны должны быть больше нуля.");

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Невозможно построить треугольник с такими сторонами.");

            A = a;
            B = b;
            C = c;
        }

        // Метод для проверки, является ли треугольник прямоугольным
        public bool IsRightTriangle()
        {
            var sides = new[] { A, B, C };
            Array.Sort(sides);
            return sides[2] * sides[2] == (sides[0] * sides[0] + sides[1] * sides[1]);
        }

        // Вычисление площади треугольника по формуле Герона
        public override double GetArea()
        {
            double p = (A + B + C) / 2; // Полупериметр
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
