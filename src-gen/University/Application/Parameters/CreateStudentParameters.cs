using System.Collections.Generic;
using University.Models;

namespace University.Application.Parameters {
	public class CreateStudentParameters {
		public int Cpr { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public List<int> StudiesDbId { get; set; }
		public List<string> OwnsBooksTitle { get; set; }
	}
}
