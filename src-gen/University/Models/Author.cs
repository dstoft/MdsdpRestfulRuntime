using System;
using System.Collections.Generic;

namespace University.Models {
	public class Author : Person {
		public Author(IExternalCode externalCode, int cpr, string name, int age) : base(externalCode, cpr, name, age)  {
			CheckRequirements();
		}
		public void CheckRequirements() {
			if(!((Age>18))) throw new Exception("Requirement not fulfilled");
		}
	}
}
