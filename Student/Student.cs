using System;
using System.Linq;

namespace Student
{
	internal class Student : ICloneable, IComparable<Student>
	{
		public string FirstName { get; set; }

		public string MiddleName { get; set; }

		public string LastName { get; set; }

		public uint? SSN { get; set; }

		public string Address { get; set; }

		public ulong? Number { get; set; }

		public string Email { get; set; }

		public string Course { get; set; }

		public Speciality? Speciality { get; set; }

		public University? University { get; set; }

		public Faculty? Faculty { get; set; }

		public int CompareTo(Student other)
		{
			if (this.FirstName.CompareTo(other.FirstName) != 0)
			{
				return this.FirstName.CompareTo(other.FirstName);
			}
			else 
			{
				if (this.SSN != other.SSN)
				{
					return (int)this.SSN - (int)other.SSN;
				}
			}

			return 0;
		}

		public object Clone()
		{
			var newStudent = new Student();

			newStudent.FirstName = this.FirstName;
			newStudent.MiddleName = this.MiddleName;
			newStudent.LastName = this.LastName;
			newStudent.SSN = this.SSN;
			newStudent.Address = this.Address;
			newStudent.Number = this.Number;
			newStudent.Email = this.Email;
			newStudent.Course = this.Course;
			newStudent.Speciality = this.Speciality;
			newStudent.University = this.University;
			newStudent.Faculty = this.Faculty;
		    
			return newStudent;
		}

		public override bool Equals(object param)
		{
			var student = param as Student;

			return student != null &&
				   this.FirstName == student.FirstName &&
				   this.MiddleName == student.MiddleName &&
				   this.LastName == student.LastName &&
				   this.SSN == student.SSN &&
				   this.Address == student.Address &&
				   this.Number == student.Number &&
				   this.Email == student.Email &&
				   this.Course == student.Course &&
				   this.Speciality == student.Speciality &&
				   this.University == student.University &&
				   this.Faculty == student.Faculty;
		}

		public override int GetHashCode()
		{
			return (this.FirstName != null ? this.FirstName.GetHashCode() : 0) ^
				   (this.MiddleName != null ? this.MiddleName.GetHashCode() : 0) ^
				   (this.LastName != null ? this.LastName.GetHashCode() : 0) ^
				   (this.SSN != null ? this.SSN.GetHashCode() : 0) ^
				   (this.Address != null ? this.Address.GetHashCode() : 0) ^
				   (this.Number != null ? this.Number.GetHashCode() : 0) ^
				   (this.Email != null ? this.Email.GetHashCode() : 0) ^
				   (this.Course != null ? this.Course.GetHashCode() : 0) ^
				   (this.Speciality != null ? this.Speciality.GetHashCode() : 0) ^
				   (this.University != null ? this.University.GetHashCode() : 0) ^
				   (this.Faculty != null ? this.Faculty.GetHashCode() : 0);
		}

		public override string ToString()
		{
			return String.Format("Student(First Name: {0}, Middle Name: {1}, Last Name: {2}, SSN: {3}, Address: {4}, Number: {5}, Email: {6}, Course: {7}, Speciality: {8}, University: {9}, Faculty: {10})",
				string.IsNullOrEmpty(this.FirstName) ? "<unnamed>" : this.FirstName,
				string.IsNullOrEmpty(this.MiddleName) ? "<unnamed>" : this.MiddleName,
				string.IsNullOrEmpty(this.LastName) ? "<unnamed>" : this.LastName,
				this.SSN.HasValue ? this.SSN.Value.ToString() : "<no SSN>",
				string.IsNullOrEmpty(this.Address) ? "<no address>" : this.Address,
				this.Number.HasValue ? this.Number.Value.ToString() : "<no number>",
				string.IsNullOrEmpty(this.Email) ? "<no email>" : this.Email,
				string.IsNullOrEmpty(this.Course) ? "<no course>" : this.Course,
				this.Speciality.HasValue ? this.Speciality.Value.ToString() : "<no speciality>",
				this.University.HasValue ? this.University.Value.ToString() : "<no university>",
				this.Faculty.HasValue ? this.Faculty.Value.ToString() : "<no faculty>");
		}

		public static bool operator ==(Student student1, Student student2)
		{
			return Student.Equals(student1, student2);
		}

		public static bool operator !=(Student student1, Student student2)
		{
			return !(Student.Equals(student1, student2));
		}
	}
}