namespace Pharmacy.Data.Classes
{
	internal class Administrator
	{
		public long Id { get; private set; }
		public string Surname { get; set; }
		public string Name { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }

		public Administrator(long Id) => this.Id = Id; //для взятия из бд, где уже есть Id

		public Administrator () => Id = -1; //для создания нового, т.к Id все равно будет новый
	}
}
