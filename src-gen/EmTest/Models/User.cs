using System;

namespace EmTest.Models {
	public class User : Person {
		public User(IExternalCode externalCode, int dbId, string name, string password, int age, int cpr, string madeOf) : base(externalCode, cpr, madeOf)  {
			this.DbId = dbId;
			this.Name = name;
			this.Password = password;
			this.Age = age;
			CheckRequirements();
		}
		public int DbId { get; }
		public string Name { get; }
		public string Password { get; }
		public int Age { get; }
		public void CheckRequirements() {
			if(!(ExternalCode.VerifyString(Name))) throw new Exception("Requirement not fulfilled");
			if(!(ExternalCode.VerifyPassword(Password))) throw new Exception("Requirement not fulfilled");
			if(!(((Age>0)&&(Age<130)))) throw new Exception("Requirement not fulfilled");
		}
	}
}
