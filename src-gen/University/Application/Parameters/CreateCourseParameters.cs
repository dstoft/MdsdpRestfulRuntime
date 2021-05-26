using System.Collections.Generic;
using University.Models;

namespace University.Application.Parameters {
	public class CreateCourseParameters {
		public string Education { get; set; }
		public string MainBookTitle { get; set; }
		public List<string> OtherMaterialTitle { get; set; }
		public string TaughtByName { get; set; }
	}
}
