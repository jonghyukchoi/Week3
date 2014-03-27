using System;

namespace Sum2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int grade1,grade2;
			string number1 = Console.ReadLine ();
			grade1 = int.Parse(number1);
			string number2 = Console.ReadLine ();
			grade2 = int.Parse(number2);

			int sum = grade1 + grade2;

			Console.WriteLine ("합 = {0}", sum);
		}
	}
}
