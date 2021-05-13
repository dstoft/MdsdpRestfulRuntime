using System;

namespace EmTest.Models {
	public class Thing {
		public Thing(IExternalCode externalCode, string madeOf)  {
			ExternalCode = externalCode;
			this.MadeOf = madeOf;
			CheckRequirements();
		}
		protected readonly IExternalCode ExternalCode;
		public string MadeOf { get; }
		public void CheckRequirements() {
		}
	}
}
