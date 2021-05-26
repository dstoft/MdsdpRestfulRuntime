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
            return new User(_externalCode, 27, parameters.Name, parameters.Password, parameters.Age, null, null, parameters.Cpr, parameters.MadeOf);
        }

        public User Get(GetUserParameters parameters)
        {
            return new User(_externalCode, 127, parameters.Name, "get password", 97, null, null, 123, "wow material");
        }

        public User Update(UpdateUserParametersWithId parameters)
        {
            return new User(_externalCode, parameters.DbId, parameters.Parameters.Name, parameters.Parameters.Password,
                parameters.Parameters.Age, null, null, 123, "wow material");
        }

        public IList<User> List(ListUserParameters parameters)
        {
            return new List<User> {new User(_externalCode, 127, "list name", "list password", 97, null, null, 123, "wow material")};
        }
    }
}