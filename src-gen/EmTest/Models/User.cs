using System;
using System.Collections.Generic;

namespace EmTest.Models {
	public class User : Person {
		public User(IExternalCode externalCode, int dbId, string name, string password, int age, Resource1 book, List<Resource1> books, int cpr, string madeOf) : base(externalCode, cpr, madeOf)  {
			this.DbId = dbId;
			this.Name = name;
			this.Password = password;
			this.Age = age;
			this.Book = book;
			this.Books = books;
			CheckRequirements();
		}
		public int DbId { get; }
		public string Name { get; }
		public string Password { get; }
		public int Age { get; }
		public Resource1 Book { get; }
		public List<Resource1> Books { get; }
		public void CheckRequirements() {
			if(!(ExternalCode.VerifyString(Name))) throw new Exception("Requirement not fulfilled");
			if(!(ExternalCode.VerifyPassword(Password))) throw new Exception("Requirement not fulfilled");
			if(!(((Age>0)&&(Age<130)))) throw new Exception("Requirement not fulfilled");
			if(!(((Age>5)||(Age<130)))) throw new Exception("Requirement not fulfilled");
			if(!(ExternalCode.VerifyPassword(Name))) throw new Exception("Requirement not fulfilled");
			if(!((Cpr>0))) throw new Exception("Requirement not fulfilled");
			if(!(ExternalCode.VerifyCpr(Cpr))) throw new Exception("Requirement not fulfilled");
			if(!(ExternalCode.VerifyString(MadeOf))) throw new Exception("Requirement not fulfilled");
			if(!(ExternalCode.VerifyString(Book.Title))) throw new Exception("Requirement not fulfilled");
		}
	}
}
