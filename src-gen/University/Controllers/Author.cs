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
	public class Author : ControllerBase {
		private readonly IAuthorService Service;
		
		public Author(IAuthorService service)
		{
		    Service = service;
		}
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		public ActionResult<Author> Create(CreateAuthorParameters parameters)
		{
			return Created("", Service.Create(parameters));
		}
		[HttpGet("{cpr}")]
		[ProducesResponseType(typeof(Author), (int) HttpStatusCode.OK)]
		public ActionResult<Author> Get(int cpr)
		{
		    return Ok(Service.Get(new GetAuthorParameters
		    {
		    	Cpr = cpr
			}));
		}
		[HttpGet]
		[ProducesResponseType(typeof(Author[]), (int) HttpStatusCode.OK)]
		public ActionResult<IList<Author>> List()
		{
		    return Ok(Service.List(new ListAuthorParameters()));
		}
		[HttpPut("{cpr}")]
		[ProducesResponseType(typeof(Author), (int) HttpStatusCode.OK)]
		public ActionResult<Author> Update(int cpr, UpdateAuthorParameters parameters)
		{
			return Ok(Service.Update(new UpdateAuthorParametersWithId
			{
				Cpr = cpr,
				Parameters = parameters
			}));
		}
	}
}
