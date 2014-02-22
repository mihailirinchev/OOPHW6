using System;
using System.Linq;

namespace Student
{
	internal class Program
	{
		static void Main()
		{
			var stud1 = new Student();
			stud1.GetHashCode();
			Console.WriteLine(stud1);
			Console.WriteLine();

			var stud2 = new Student();
			stud2.FirstName = "pesho";
			stud2.LastName = "peshev";
			stud2.Speciality = Speciality.Math;
			stud2.University = University.SU;
			stud2.SSN = 5;
			stud2.GetHashCode();

			Console.WriteLine(stud2);
			Console.WriteLine();

			Console.WriteLine("Is stud2 equals stud1: {0}", stud1.Equals(stud2));
			Console.WriteLine();

			var stud3 = (Student)stud2.Clone();

			Console.WriteLine(stud3);
			Console.WriteLine();

			Console.WriteLine("Student 2 compare to Student 3: {0}", stud2.CompareTo(stud3));

			stud3.FirstName += 'a';
			stud3.SSN += 1;

			Console.WriteLine("Student 2 compare to Student 3: {0}", stud2.CompareTo(stud3));
		}
	}
}