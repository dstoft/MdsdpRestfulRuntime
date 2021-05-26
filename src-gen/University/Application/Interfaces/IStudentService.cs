using System.Collections.Generic;
using University.Application.Parameters;
using University.Models;

namespace University.Application.Interfaces {
	public interface IStudentService {
		public Student Create(CreateStudentParameters parameters);
		public Student Get(GetStudentParameters parameters);
		public IList<Student> List(ListStudentParameters parameters);
		public Student Update(UpdateStudentParametersWithId parameters);
		public void Delete(DeleteStudentParameters parameters);
	}
}
