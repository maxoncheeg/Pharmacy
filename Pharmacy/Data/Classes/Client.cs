using System;

namespace Pharmacy.Data.Classes
{
	public class Client
	{
		public long Id { get; private set; }
		public string Surname { get; set; }
		public string Name { get; set; }
		public DateTime BirthDate { get; set; }

		public Client(long Id) => this.Id = Id;

		public Client() => Id = -1;
	}
}
