using System;

<<<<<<< HEAD
namespace TriangleTypeIdentifier
=======
namespace GradeCalculator
>>>>>>> 8bb90e7840419b7f022393c917db1fb359128c97
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.Write("Enter side 1: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Enter side 2: ");
            double side2 = double.Parse(Console.ReadLine());

            Console.Write("Enter side 3: ");
            double side3 = double.Parse(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("The triangle is Isosceles");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene");
            }
        }
    }
}
=======
            Console.Write("Enter your grade (0-100): ");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 90)
            {
                Console.WriteLine("Your grade is: A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Your grade is: B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Your grade is: C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Your grade is: D");
            }
            else
            {
                Console.WriteLine("Your grade is: F");
            }
        }
    }
}
>>>>>>> 8bb90e7840419b7f022393c917db1fb359128c97
