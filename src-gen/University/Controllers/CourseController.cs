using University.Models;
using University.Application.Interfaces;
using University.Application.Parameters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;

namespace University.Controllers {
	[Route("api/[controller]")]
    [Produces("application/json")]
    [Consumes("application/json")]
	public class CourseController : ControllerBase {
		private readonly ICourseService Service;
		
		public CourseController(ICourseService service)
		{
		    Service = service;
		}
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		public ActionResult<Course> Create(CreateCourseParameters parameters)
		{
			return Created("", Service.Create(parameters));
		}
		[HttpGet]
		[ProducesResponseType(typeof(Course[]), (int) HttpStatusCode.OK)]
		public ActionResult<IList<Course>> List()
		{
		    return Ok(Service.List(new ListCourseParameters()));
		}
	}
}
