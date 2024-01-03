using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            CalculateTotalCost();
        }

        static double Rect(double length, double width)
        {
            return length * width;
        }

        static double Circle(double radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

        static double Triangle(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }

        static void CalculateTotalCost()
        {
            Console.WriteLine("What monument would you like to work with?");
            Console.Write("Choose Taj Mahal (1), Mecca (2), Teotihuacan (3): ");
            string monument = Console.ReadLine();
            double TotalArea;
            double TotalCost;

            switch (monument)
            {
                case "1":
                    Console.WriteLine("\nTaj Mahal monument cost details");
                    TotalArea = Rect(90.5, 90.5) - 2 * Rect(24, 24);
                    break;

                case "2":
                    Console.WriteLine("\nMecca monument cost details");
                    TotalArea = Rect(180, 106) + 2 * Rect(200, 264) + Triangle(264, 84);
                    break;

                case "3":
                    Console.WriteLine("\nTeotihuacan monument cost details");
                    TotalArea = Rect(2500, 1500) + (Circle(375) / 2) + Triangle(750, 500);
                    break;

                default:
                    TotalArea = 0;
                    break;
            }

            Console.WriteLine("Total Area:" + TotalArea);
            TotalCost = Math.Round((TotalArea * 180), 2);
            Console.WriteLine($"My plan costs: {TotalCost} pesos\n");
        }
    }
}

