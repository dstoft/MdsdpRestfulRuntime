using System;
using System.Collections.Generic;

namespace EmTest.Models {
	public class Person : Thing {
		public Person(IExternalCode externalCode, int cpr, string madeOf) : base(externalCode, madeOf)  {
			this.Cpr = cpr;
			CheckRequirements();
		}
		public int Cpr { get; }
		public void CheckRequirements() {
		}
	}
}
