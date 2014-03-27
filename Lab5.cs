using System;

namespace Average2
{
	class Student
	{
		public string Name;
		public int Korean;
		public int English;
		public int Mathematics;
		public int Science;

		public Student (string _Name, int _Korean, int _English, int _Mathematics, int _Science)
		{
			Name 		= _Name;
			Korean 		= _Korean;
			English 	= _English;
			Mathematics = _Mathematics;
			Science 	= _Science;
		}
		public int Average ()
		{
			return (Korean + English + Mathematics + Science) / 4;
		}
	}

	class MainApp
	{
		public static void Main(string[] args)
		{
			Student Jonghyuk = new Student ("Name", 10, 20, 30, 40);
			Jonghyuk.Name = "최종혁";
			Console.Write(Jonghyuk.Average ());
		}
	}
}