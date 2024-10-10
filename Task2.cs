using System;


namespace pr_1
{
    public class Task2 : ITask
    {
        private double a, b, c;

        public Task2(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides of a triangle must be positive numbers.");
            }
            this.a = sideA;
            this.b = sideB;
            this.c = sideC;
        }

        public void ExecuteTask()
        {
            if (IsValidTriangle())
            {
                Triangle triangle = new Triangle(a, b, c);

                double perimeter = triangle.CalculatePerimeter();
                double area = triangle.CalculateArea();
                string triangleType = triangle.DefineTriangleType();

                Console.WriteLine("Task 2:");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Triangle Type: {triangleType}\n");
            }
            else
            {
                Console.WriteLine("Task 2: The given sides do not form a valid triangle\n");
            }
        }

        private bool IsValidTriangle()
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}