using System;

namespace Pharmacy.Data.Classes
{
	internal class Purchase
	{
		public long Id { get; private set; }
		public long ClientId { get; set; }
		public long PharmacistId { get; set; }
		public DateTime PurchaseDate { get; set; }
		public double TotalPrice { get; set; }
		public TimeSpan PursacheTime { get; set; }

		public Purchase(long Id) => this.Id = Id;

		public Purchase() => Id = -1;
	}
}
