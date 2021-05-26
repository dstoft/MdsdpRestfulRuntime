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
	public class StudentController : ControllerBase {
		private readonly IStudentService Service;
		
		public StudentController(IStudentService service)
		{
		    Service = service;
		}
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		public ActionResult<Student> Create(CreateStudentParameters parameters)
		{
			return Created("", Service.Create(parameters));
		}
		[HttpGet("{studentId}")]
		[ProducesResponseType(typeof(Student), (int) HttpStatusCode.OK)]
		public ActionResult<Student> Get(int studentId)
		{
		    return Ok(Service.Get(new GetStudentParameters
		    {
		    	StudentId = studentId
			}));
		}
		[HttpGet]
		[ProducesResponseType(typeof(Student[]), (int) HttpStatusCode.OK)]
		public ActionResult<IList<Student>> List()
		{
		    return Ok(Service.List(new ListStudentParameters()));
		}
		[HttpPut("{studentId}")]
		[ProducesResponseType(typeof(Student), (int) HttpStatusCode.OK)]
		public ActionResult<Student> Update(int studentId, UpdateStudentParameters parameters)
		{
			return Ok(Service.Update(new UpdateStudentParametersWithId
			{
				StudentId = studentId,
				Parameters = parameters
			}));
		}
		[HttpDelete("{studentId}")]
		[ProducesResponseType((int) HttpStatusCode.OK)]
		public ActionResult Delete(int studentId)
		{
		    Service.Delete(new DeleteStudentParameters
		    {
		    	StudentId = studentId
			});
			return Ok();
		}
	}
}
