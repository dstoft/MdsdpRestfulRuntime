using System;
using System.Collections.Generic;

namespace University.Models {
	public class Course {
		public Course(IExternalCode externalCode, int dbId, Book mainBook, List<Book> otherMaterial, Teacher taughtBy, string education)  {
			ExternalCode = externalCode;
			this.DbId = dbId;
			this.MainBook = mainBook;
			this.OtherMaterial = otherMaterial;
			this.TaughtBy = taughtBy;
			this.Education = education;
			CheckRequirements();
		}
		protected readonly IExternalCode ExternalCode;
		public int DbId { get; }
		public Book MainBook { get; }
		public List<Book> OtherMaterial { get; }
		public Teacher TaughtBy { get; }
		public string Education { get; }
		public void CheckRequirements() {
			if(!((Education==TaughtBy.Education))) throw new Exception("Requirement not fulfilled");
			if(!((TaughtBy.Age>25))) throw new Exception("Requirement not fulfilled");
			if(!(ExternalCode.VerifyIsUniversityMaterial(MainBook.IndustryArea))) throw new Exception("Requirement not fulfilled");
		}
	}
}
