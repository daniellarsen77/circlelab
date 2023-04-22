namespace Circleobjectlab
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double radius;
            Circle circle;

            do
            {
                Console.Write("Enter the radius of the circle: ");
                string input = Console.ReadLine();

                if (!double.TryParse(input, out radius))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number with decimals.");
                    continue;
                }

                circle = new Circle(radius);
                break;
            } while (true);

            Console.WriteLine($"Diameter: {circle.CalculateDiameter():F2}");
            Console.WriteLine($"Circumference: {circle.CalculateCircumference():F2}");
            Console.WriteLine($"Area: {circle.CalculateArea():F2}");

            do
            {
                Console.Write("Would you like to grow the circle? (yes/no): ");
                string input = Console.ReadLine().ToLower();

                if (input == "yes" || input == "y")
                {
                    circle.Grow();
                    Console.WriteLine($"Diameter: {circle.CalculateDiameter():F2}");
                    Console.WriteLine($"Circumference: {circle.CalculateCircumference():F2}");
                    Console.WriteLine($"Area: {circle.CalculateArea():F2}");
                }
                else if (input == "no" || input == "n")
                {
                    Console.WriteLine($"Goodbye! The final radius of the circle is {circle.GetRadius():F2}.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter \"yes\" or \"no\".");
                }
            } while (true);
        }
    }

}