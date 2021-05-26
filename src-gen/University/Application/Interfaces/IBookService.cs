using System.Collections.Generic;
using University.Application.Parameters;
using University.Models;

namespace University.Application.Interfaces {
	public interface IBookService {
		public Book Create(CreateBookParameters parameters);
		public IList<Book> List(ListBookParameters parameters);
	}
}
