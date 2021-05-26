using System;
using System.Collections.Generic;

namespace University.Models {
	public class Teacher : Person {
		public Teacher(IExternalCode externalCode, string education, int cpr, string name, int age) : base(externalCode, cpr, name, age)  {
			this.Education = education;
			CheckRequirements();
		}
		public string Education { get; }
		public void CheckRequirements() {
			if(!((Age>18))) throw new Exception("Requirement not fulfilled");
		}
	}
}
