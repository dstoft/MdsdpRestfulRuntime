using System.Collections.Generic;
using University.Application.Interfaces;
using University.Application.Parameters;
using University.Models;

namespace RestfulRuntime
{
    public class StudentService : IStudentService
    {
        public Student Create(CreateStudentParameters parameters)
        {
            throw new System.NotImplementedException();
        }

        public Student Get(GetStudentParameters parameters)
        {
            throw new System.NotImplementedException();
        }

        public IList<Student> List(ListStudentParameters parameters)
        {
            throw new System.NotImplementedException();
        }

        public Student Update(UpdateStudentParametersWithId parameters)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(DeleteStudentParameters parameters)
        {
            throw new System.NotImplementedException();
        }
    }
}