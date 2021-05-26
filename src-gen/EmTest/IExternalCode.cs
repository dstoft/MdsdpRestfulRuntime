using System.Collections.Generic;
using EmTest.Models;

namespace EmTest {
	public interface IExternalCode {
		public bool VerifyString(string parameter);
		public bool VerifyPassword(string parameter);
		public bool VerifyCpr(int parameter);
		public bool VerifyBooks(List<Resource1> parameter);
	}
}
