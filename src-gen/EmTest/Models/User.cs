using System;

namespace EmTest.Models {
	public class User {
		public User(IExternalCode externalCode, int dbId, string name, string password, int age) {
			ExternalCode = externalCode;
			this.DbId = dbId;
			this.Name = name;
			this.Password = password;
			this.Age = age;
		}
		private readonly IExternalCode ExternalCode;
		public int DbId { get; }
		public string Name { get; }
		public string Password { get; }
		public int Age { get; }
		public void checkRequirements() {
			if(!(ExternalCode.VerifyString(Name))) throw new Exception("Requirement not fulfilled");
			if(!(ExternalCode.mcWow(Password))) throw new Exception("Requirement not fulfilled");
			if(!(((Age>0)&&(Age<130)))) throw new Exception("Requirement not fulfilled");
		}
	}
}
