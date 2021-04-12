using System.Collections.Generic;
using EmTest.Application.Parameters;
using EmTest.Models;

namespace EmTest.Application.Interfaces {
	public interface IUserService {
		public User Create(CreateUserParameters parameters);
		public User Get(GetUserParameters parameters);
		public User Update(UpdateUserParametersWithId parameters);
		public IList<User> List(ListUserParameters parameters);
	}
}
