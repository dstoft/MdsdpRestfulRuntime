using System.Collections.Generic;
using University.Application.Interfaces;
using University.Application.Parameters;
using University.Models;

namespace RestfulRuntime
{
    public class AuthorService : IAuthorService
    {
        public Author Create(CreateAuthorParameters parameters)
        {
            throw new System.NotImplementedException();
        }

        public Author Get(GetAuthorParameters parameters)
        {
            throw new System.NotImplementedException();
        }

        public IList<Author> List(ListAuthorParameters parameters)
        {
            throw new System.NotImplementedException();
        }

        public Author Update(UpdateAuthorParametersWithId parameters)
        {
            throw new System.NotImplementedException();
        }
    }
}