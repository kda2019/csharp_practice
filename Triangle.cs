namespace pr_1
{
    public class Triangle : Figures
    {
        private double a, b, c;

        public Triangle(double sideA, double sideB, double sideC)
        {
            a = sideA;
            b = sideB;
            c = sideC;
        }

        public override double CalculatePerimeter()
        {
            return a + b + c;
        }

        public override double CalculateArea()
        {
            double semiPerimeter = CalculatePerimeter() / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
        }

        public string DefineTriangleType()
        {
            if (a == b && b == c) return "Equilateral";
            if (a == b || b == c || a == c) return "Isosceles";
            return "Scalene";
        }
    }
}