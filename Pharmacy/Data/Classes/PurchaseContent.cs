namespace Pharmacy.Data.Classes
{
	internal class PurchaseContent
	{
		public long Id { get; private set; }
		public long PurchaseId { get; set; }
		public long MedicationId { get; set; }

		public PurchaseContent(long Id) => this.Id = Id;

		public PurchaseContent() => Id = -1;
	}
}
