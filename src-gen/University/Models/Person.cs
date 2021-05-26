using System;
using System.Collections.Generic;

namespace University.Models {
	public class Person {
		public Person(IExternalCode externalCode, int cpr, string name, int age)  {
			ExternalCode = externalCode;
			this.Cpr = cpr;
			this.Name = name;
			this.Age = age;
			CheckRequirements();
		}
		protected readonly IExternalCode ExternalCode;
		public int Cpr { get; }
		public string Name { get; }
		public int Age { get; }
		public void CheckRequirements() {
			if(!(ExternalCode.VerifyCpr(Cpr))) throw new Exception("Requirement not fulfilled");
			if(!(ExternalCode.VerifyName(Name))) throw new Exception("Requirement not fulfilled");
			if(!(((Age>0)&&(Age<130)))) throw new Exception("Requirement not fulfilled");
		}
	}
}
