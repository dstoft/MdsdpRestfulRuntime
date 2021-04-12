using System.Collections.Generic;
using EmTest;
using EmTest.Application.Interfaces;
using EmTest.Application.Parameters;
using EmTest.Models;

namespace RestfulRuntime
{
    public class UserService : IUserService
    {
        private readonly IExternalCode _externalCode;

        public UserService(IExternalCode externalCode)
        {
            _externalCode = externalCode;
        }

        public User Create(CreateUserParameters parameters)
        {
            return new User(_externalCode, 27, parameters.Name, parameters.Password, parameters.Age);
        }

        public User Get(GetUserParameters parameters)
        {
            return new User(_externalCode, 127, parameters.Name, "get password", 97);
        }

        public User Update(UpdateUserParametersWithId parameters)
        {
            return new User(_externalCode, parameters.DbId, parameters.Parameters.Name, parameters.Parameters.Password,
                parameters.Parameters.Age);
        }

        public IList<User> List(ListUserParameters parameters)
        {
            return new List<User> {new User(_externalCode, 127, "list name", "list password", 97)};
        }
    }
}