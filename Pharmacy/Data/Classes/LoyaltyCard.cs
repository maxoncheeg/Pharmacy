using System;

namespace Pharmacy.Data.Classes
{
	internal class LoyaltyCard
	{
		public long Id { get; private set; }
		public DateTime RegistrationDate { get; set; }

		public LoyaltyCard(long Id) => this.Id = Id;

		public LoyaltyCard() => Id = -1;
	}
}
