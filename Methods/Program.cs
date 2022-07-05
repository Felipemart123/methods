


namespace Methods
{
	
	

	class Test
	{
		public static int Sum(int num1, int num2)
		{
			var answer = num1 + num2;
			return answer;
		}

		public static int Multiply(int num1, int num2, int num3)
		{
			var answer = num1 * num2 + num3;
			return answer;
		}

		public static int Plus(int num1, int num2, int num3, int num4 ,int num5)
		{
			var answer = num1 + num2 + num3 + num4 + num5;
			return answer;
		}

		static void Main(string[] args)
		{
			var plusFive = Plus(1, 1, 1,1,1 );
			Console.WriteLine(plusFive);

			var timesThree = Multiply(2, 4, 6);
			Console.WriteLine(timesThree);

			var numOfPeople = Sum(2, 4);
            Console.WriteLine(numOfPeople);

			Console.WriteLine("Hello, What is your name?");
			var name = Console.ReadLine();

			Console.WriteLine($"Hello {name} What is Favorite color?");
			var color = Console.ReadLine();

			Console.WriteLine($"{color} is my favorite too! Do you have a Favorite animal?");
			var animal = Console.ReadLine();

			Console.WriteLine($"tell me {name} what is Favorite band?");
			var band = Console.ReadLine(); 

		}
	}
}