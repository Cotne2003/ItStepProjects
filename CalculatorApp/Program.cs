namespace Calculator
{
	internal class Calculator
	{
		static void Main(string[] Args)
		{
			Console.WriteLine("Hello, this is calculator. (enter any key to start)");

			Console.ReadKey();
			Console.Clear();

			double firstNumber = GetNumber("Please, enter your first number: ");

			double secondNumber = GetNumber("Please, enter your second number: ");

			string? mathematicalOperator = GetOperator();


			double result = mathematicalOperator switch
			{
				"+" => firstNumber + secondNumber,
				"-" => firstNumber - secondNumber,
				"/" => firstNumber / secondNumber,
				"*" => firstNumber * secondNumber,
				"%" => firstNumber % secondNumber,
				_ => 0
			};

			Console.WriteLine($"{firstNumber} {mathematicalOperator} {secondNumber} = {result}");


			double GetNumber(string prompt)
			{
				while (true)
				{
					Console.Write(prompt);
					if (double.TryParse(Console.ReadLine(), out double number))
						return number;
					Console.WriteLine("Invalid input.");
				}
			}

			string GetOperator()
			{
				while (true)
				{
					Console.Write("Choose operator (+, -, *, /, %): ");
					string? mathematicalOperator = Console.ReadLine();
					if
					(
						mathematicalOperator == "+"
						|| mathematicalOperator == "-"
						|| mathematicalOperator == "*"
						|| mathematicalOperator == "/"
						|| mathematicalOperator == "%"
					)
					{
						return mathematicalOperator;
					}
					Console.WriteLine("Invalid input, please try again.");
				}
			}
		}
	}

}
