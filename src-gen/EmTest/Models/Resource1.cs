using System;
using System.Collections.Generic;

namespace EmTest.Models {
	public class Resource1 : GeneralResource {
		public Resource1(IExternalCode externalCode, string title, int age) : base(externalCode, age)  {
			this.Title = title;
			CheckRequirements();
		}
		public string Title { get; }
		public void CheckRequirements() {
		}
	}
}
