using System;

namespace Sum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num1 = 100;
			int num2 = 200;
			int sum = num1 + num2; // 변수가 올 수 있을 뿐만 아니라 변수의 합도 올 수 있음.

			Console.WriteLine ("첫번째 수: {0} , 두번째 수: {1} , 합: {2}", num1, num2, sum);
		}
	}
}
