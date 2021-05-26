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
	public class BookController : ControllerBase {
		private readonly IBookService Service;
		
		public BookController(IBookService service)
		{
		    Service = service;
		}
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		public ActionResult<Book> Create(CreateBookParameters parameters)
		{
			return Created("", Service.Create(parameters));
		}
		[HttpGet]
		[ProducesResponseType(typeof(Book[]), (int) HttpStatusCode.OK)]
		public ActionResult<IList<Book>> List()
		{
		    return Ok(Service.List(new ListBookParameters()));
		}
	}
}
