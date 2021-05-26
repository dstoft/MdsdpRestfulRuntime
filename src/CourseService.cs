using System.Collections.Generic;
using University.Application.Interfaces;
using University.Application.Parameters;
using University.Models;

namespace RestfulRuntime
{
    public class CourseService : ICourseService
    {
        public Course Create(CreateCourseParameters parameters)
        {
            throw new System.NotImplementedException();
        }

        public IList<Course> List(ListCourseParameters parameters)
        {
            throw new System.NotImplementedException();
        }
    }
}