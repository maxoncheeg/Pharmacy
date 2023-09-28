namespace Pharmacy.Data.Classes
{
	public class Medication
	{
		public long Id { get; private set; }
		public string Name { get; set; }
		public long Amount { get; set; }
		public double Price { get; set; }

		public Medication(long Id) => this.Id = Id;

		public Medication() => Id = -1;
	}
}
