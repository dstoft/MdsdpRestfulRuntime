using System;
using System.Collections.Generic;

namespace EmTest.Models {
	public class GeneralResource {
		public GeneralResource(IExternalCode externalCode, int age)  {
			ExternalCode = externalCode;
			this.Age = age;
			CheckRequirements();
		}
		protected readonly IExternalCode ExternalCode;
		public int Age { get; }
		public void CheckRequirements() {
		}
	}
}
