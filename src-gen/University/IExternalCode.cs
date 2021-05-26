using System.Collections.Generic;
using University.Models;

namespace University {
	public interface IExternalCode {
		public bool VerifyName(string parameter);
		public bool VerifyBookTitle(string parameter);
		public bool VerifyCpr(int parameter);
		public bool VerifyIsUniversityMaterial(string parameter);
	}
}
