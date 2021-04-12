namespace EmTest.Application.Parameters {
	public class UpdateUserParametersWithId {
		public int DbId { get; set; }
		public UpdateUserParameters Parameters { get; set; }
	}
	public class UpdateUserParameters {
		public string Name { get; set; }
		public string Password { get; set; }
		public int Age { get; set; }
	}
}
