using System;

namespace EmTest.Models {
	public class Potato {
		public Potato(IExternalCode externalCode, string kind, int age) {
			ExternalCode = externalCode;
			this.kind = kind;
			this.age = age;
		}
		private readonly IExternalCode ExternalCode;
		public string kind { get; }
		public int age { get; }
		public void checkRequirements() {
		}
	}
}
