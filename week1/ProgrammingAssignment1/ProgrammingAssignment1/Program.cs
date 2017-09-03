using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1 {

    /// <summary>
    /// Solution to week 1's assignment
    /// </summary>
    class Program {

        /// <summary>
        /// Main method of the program
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args) {

            Console.WriteLine("Welcome, this application will calculate the distance between two points and the angle between them.");
            Console.WriteLine();

            // Get first point's coordinates
            Console.Write("Enter the first point's X coordinate: ");
            float point1X = float.Parse(Console.ReadLine());
            Console.Write("Enter the first point's Y coordinate: ");
            float point1Y = float.Parse(Console.ReadLine());
            Console.WriteLine();

            // Get second point's coordinates
            Console.Write("Enter the second point's X coordinate: ");
            float point2X = float.Parse(Console.ReadLine());
            Console.Write("Enter the second point's Y coordinate: ");
            float point2Y = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"You've entered points ({point1X}, {point1Y}) and ({point2X}, {point2Y}).");
            Console.WriteLine();

            float deltaX = point2X - point1X;
            float deltaY = point2Y - point1Y;

            // Calculating the distance
            float distance = (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            // Calculate the angle from point 1 to point 2 (in degrees)
            double angleInRadians = Math.Atan2(deltaY, deltaX);
            float angleInDegrees = (float)(angleInRadians * 180 / Math.PI);

            // Print the results
            Console.WriteLine($"The distance between the points is {distance.ToString("F3")}");
            Console.WriteLine($"The angle from the first point to the second point is {angleInDegrees.ToString("F3")} degrees");
            Console.WriteLine();
        }
    }

}
