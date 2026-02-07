using System;

namespace MathApp
{
	class MathProgram
	{

		static void Main(string[] args)
		{

			double number1 = -15.3;
			int number2 = 9;
			double number3 = 3.14;
			double number4 = 120.8;


			Console.WriteLine("The Power of the " + number2 + " is: " + Math.Pow(number2, 4));
			Console.WriteLine("The Absolute of " + number1 + " is: " + Math.Abs(number1));
			Console.WriteLine("The Ceiling of " + number3 + " is: " + Math.Ceiling(number3));
			Console.WriteLine("The Square root of " + number4 + " is: " + Math.Sqrt(number4));
			Console.WriteLine("The expontent to " + number4 + " is: " + Math.Exp(number4));

			Console.WriteLine("Press any key to proceed");
			Console.ReadKey();
		}
	}
}
