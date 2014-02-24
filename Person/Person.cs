using System;

namespace Person
{
	internal class Person
	{
		public string Name { get; set; }

		public uint? Age { get; set; }

		public override string ToString()
		{
			return String.Format("Student(Name: {0}, Age: {1})",
				string.IsNullOrEmpty(this.Name) ? "<unnamed>" : this.Name,
				this.Age.HasValue ? this.Age.Value.ToString() : "<not specified>");
		}
	}
}