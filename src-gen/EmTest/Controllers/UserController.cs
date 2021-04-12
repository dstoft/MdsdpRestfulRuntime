using EmTest.Models;
using EmTest.Application.Interfaces;
using EmTest.Application.Parameters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;

namespace EmTest.Controllers {
	[Route("api/[controller]")]
    [Produces("application/json")]
    [Consumes("application/json")]
	public class UserController : ControllerBase {
		private readonly IUserService Service;
		
		public UserController(IUserService service)
		{
		    Service = service;
		}
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		public ActionResult<User> Create(CreateUserParameters parameters)
		{
			return Created("", Service.Create(parameters));
		}
		[HttpGet("{name}")]
		[ProducesResponseType(typeof(User), (int) HttpStatusCode.OK)]
		public ActionResult<User> Get(string name)
		{
		    return Ok(Service.Get(new GetUserParameters
		    {
		    	Name = name
			}));
		}
		[HttpPut("{dbId}")]
		[ProducesResponseType(typeof(User), (int) HttpStatusCode.OK)]
		public ActionResult<User> Update(int dbId, UpdateUserParameters parameters)
		{
			return Ok(Service.Update(new UpdateUserParametersWithId
			{
				DbId = dbId,
				Parameters = parameters
			}));
		}
		[HttpGet]
		[ProducesResponseType(typeof(User[]), (int) HttpStatusCode.OK)]
		public ActionResult<IList<User>> List()
		{
		    return Ok(Service.List(new ListUserParameters()));
		}
	}
}
