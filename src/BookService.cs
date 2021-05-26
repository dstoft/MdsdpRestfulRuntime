using System.Collections.Generic;
using University.Application.Interfaces;
using University.Application.Parameters;
using University.Models;

namespace RestfulRuntime
{
    public class BookService : IBookService
    {
        public Book Create(CreateBookParameters parameters)
        {
            throw new System.NotImplementedException();
        }

        public IList<Book> List(ListBookParameters parameters)
        {
            throw new System.NotImplementedException();
        }
    }
}