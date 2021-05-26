using System.Collections.Generic;
using University.Application.Parameters;
using University.Models;

namespace University.Application.Interfaces {
	public interface IAuthorService {
		public Author Create(CreateAuthorParameters parameters);
		public Author Get(GetAuthorParameters parameters);
		public IList<Author> List(ListAuthorParameters parameters);
		public Author Update(UpdateAuthorParametersWithId parameters);
	}
}
