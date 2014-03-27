using System;

namespace Average
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num1 = 100;
			int num2 = 200;
			int num3 = 300;
			int num4 = 400;
			int average = (num1 + num2 + num3 + num4) / 4;

			Console.WriteLine ("첫번째 숫자: {0}, 두번째 숫자: {1}, 세번째 숫자: {2}, 네번째 숫자: {3}", num1, num2, num3, num4);

			Console.WriteLine ("평균: {0}", average);
		}
	}
}
