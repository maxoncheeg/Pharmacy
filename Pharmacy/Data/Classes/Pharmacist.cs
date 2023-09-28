namespace Pharmacy.Data.Classes
{
	public class Pharmacist
	{
		public long Id { get; private set; }
		public string Surname { get; set; }
		public string Name { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }

		public Pharmacist(long Id) => this.Id = Id;

		public Pharmacist() => Id = -1;
	}
}
