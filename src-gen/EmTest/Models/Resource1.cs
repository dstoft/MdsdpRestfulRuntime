using System;

namespace EmTest.Models {
	public class Resource1 {
		public Resource1(IExternalCode externalCode, string kind, int age) {
			ExternalCode = externalCode;
			this.kind = kind;
			this.age = age;
			CheckRequirements();
		}
		private readonly IExternalCode ExternalCode;
		public string kind { get; }
		public int age { get; }
		public void CheckRequirements() {
		}
	}
}
