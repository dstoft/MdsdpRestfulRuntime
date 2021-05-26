using System.Collections.Generic;
using University.Models;

namespace University.Application.Parameters {
	public class UpdateStudentParametersWithId {
		public int StudentId { get; set; }
		public UpdateStudentParameters Parameters { get; set; }
	}
	public class UpdateStudentParameters {
		public List<Course> Studies { get; set; }
		public List<Book> OwnsBooks { get; set; }
	}
}
