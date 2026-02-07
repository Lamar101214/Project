using System;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of values you want to average:");

            double g1 = Convert.ToDouble(Console.ReadLine());
            double g2 = Convert.ToDouble(Console.ReadLine());
            double g3 = Convert.ToDouble(Console.ReadLine());
            double g4 = Convert.ToDouble(Console.ReadLine());
            double g5 = Convert.ToDouble(Console.ReadLine());

            double average = (g1 + g2 + g3 + g4 + g5) / 5;
            double roundedAverage = Math.Round(roundedAverage);

            

            Console.WriteLine("The average is: " + average + " while its rounded off average is: " + roundedAverage);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

