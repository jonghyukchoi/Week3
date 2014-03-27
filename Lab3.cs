using System;

namespace String
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string name = "최종혁";
			string greeting = "Hello, ";
			string result = greeting + name;

			Console.WriteLine ("{0} - 문자수: {1}", result, result.Length);
		}
	}
}`