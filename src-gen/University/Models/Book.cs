using System;
using System.Collections.Generic;

namespace University.Models {
	public class Book {
		public Book(IExternalCode externalCode, Author author, string title, string industryArea)  {
			ExternalCode = externalCode;
			this.Author = author;
			this.Title = title;
			this.IndustryArea = industryArea;
			CheckRequirements();
		}
		protected readonly IExternalCode ExternalCode;
		public Author Author { get; }
		public string Title { get; }
		public string IndustryArea { get; }
		public void CheckRequirements() {
		}
	}
}
