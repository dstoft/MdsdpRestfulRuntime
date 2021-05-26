using System;
using System.Collections.Generic;

namespace University.Models {
	public class Student : Person {
		public Student(IExternalCode externalCode, int studentId, List<Course> studies, List<Book> ownsBooks, int cpr, string name, int age) : base(externalCode, cpr, name, age)  {
			this.StudentId = studentId;
			this.Studies = studies;
			this.OwnsBooks = ownsBooks;
			CheckRequirements();
		}
		public int StudentId { get; }
		public List<Course> Studies { get; }
		public List<Book> OwnsBooks { get; }
		public void CheckRequirements() {
			if(!(((StudentId>=1000)&&(StudentId<10000)))) throw new Exception("Requirement not fulfilled");
		}
	}
}
