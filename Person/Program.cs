using System;

namespace Person
{
	internal class Program
	{
		private static void Main()
		{
			var ivan = new Person();
			ivan.Name = "Ivan";

			Console.WriteLine(ivan);

			var pesho = new Person();
			pesho.Name = "Pesho";
			pesho.Age = 7;

			Console.WriteLine(pesho);
		}
	}
}