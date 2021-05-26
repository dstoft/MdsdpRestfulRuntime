using System.Collections.Generic;
using University.Application.Parameters;
using University.Models;

namespace University.Application.Interfaces {
	public interface ICourseService {
		public Course Create(CreateCourseParameters parameters);
		public IList<Course> List(ListCourseParameters parameters);
	}
}
