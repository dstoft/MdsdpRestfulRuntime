namespace EmTest {
	public interface IExternalCode {
		public bool VerifyString(string parameter);
		public bool VerifyPassword(string parameter);
		public bool VerifyCpr(int parameter);
	}
}
